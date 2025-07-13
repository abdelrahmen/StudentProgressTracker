using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using StudentProgressTracker.Application.Abstractions.Students;
using StudentProgressTracker.Application.DTOs.ActivityLogs;
using StudentProgressTracker.Application.DTOs.Assessments;
using StudentProgressTracker.Application.DTOs.Students;
using StudentProgressTracker.Application.Helpers;
using StudentProgressTracker.Application.ResponseModel;
using StudentProgressTracker.Domain.Constants;
using StudentProgressTracker.Domain.Entities;
using StudentProgressTracker.Domain.Exceptions;
using StudentProgressTracker.Domain.Resources;
using StudentProgressTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Services.Students;

public class StudentService : IStudentService
{
    private readonly ApplicationDbContext _context;
    private readonly IMemoryCache _cache;

    public StudentService(ApplicationDbContext context, IMemoryCache cache)
    {
        _context = context;
        _cache = cache;
    }

    public async Task<PaginatedResponseModel<List<StudentListDto>>> GetStudentsAsync(StudentFilterDto filter)
    {
        var cacheKey = GenerateStudentCacheKey(filter);

        if (_cache.TryGetValue(cacheKey, out PaginatedResponseModel<List<StudentListDto>> cachedResult))
            return cachedResult!;

        var query = _context.Users
            .Where(u => u.Role == Roles.Student)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
            query = query.Where(u => u.FirstName.Contains(filter.SearchTerm) ||
                                     u.LastName.Contains(filter.SearchTerm) ||
                                     u.Email.Contains(filter.SearchTerm));

        if (filter.Grade.HasValue)
            query = query.Where(u => u.Grade == filter.Grade.Value);

        if (filter.SubjectId.HasValue)
            query = query.Where(u => u.StudentProgress.Any(sp => sp.SubjectId == filter.SubjectId.Value));

        if (filter.StartDate.HasValue)
            query = query.Where(u => u.EnrollmentDate >= filter.StartDate.Value);

        if (filter.EndDate.HasValue)
            query = query.Where(u => u.EnrollmentDate <= filter.EndDate.Value);

        var totalRecords = await query.CountAsync();

        // Apply sorting
        switch (filter.SortBy?.ToLower())
        {
            case "name":
                query = filter.SortOrder?.ToLower() == "desc"
                    ? query.OrderByDescending(u => u.LastName).ThenByDescending(u => u.FirstName)
                    : query.OrderBy(u => u.LastName).ThenBy(u => u.FirstName);
                break;
            case "progress":
                // To sort by progress, we need to average completion/performance.
                // This is a simplified average. For more complex logic, consider a view or a dedicated calculation.
                query = query.Include(u => u.StudentProgress); // Eager load progress for sorting
                query = filter.SortOrder?.ToLower() == "desc"
                    ? query.OrderByDescending(u => u.StudentProgress.Any() ? u.StudentProgress.Average(sp => sp.CompletionPercentage) : 0)
                    : query.OrderBy(u => u.StudentProgress.Any() ? u.StudentProgress.Average(sp => sp.CompletionPercentage) : 0);
                break;
            case "lastactivity":
                query = filter.SortOrder?.ToLower() == "desc"
                    ? query.OrderByDescending(u => u.LastActivityDate)
                    : query.OrderBy(u => u.LastActivityDate);
                break;
            default:
                query = query.OrderBy(u => u.LastName).ThenBy(u => u.FirstName); // Default sort
                break;
        }

        // Apply pagination
        var students = await query
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .Select(u => new StudentListDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Grade = u.Grade.ToString()!,
                EnrollmentDate = u.EnrollmentDate,
                LastActivityDate = u.LastActivityDate,
                // Calculate overall progress for list view
                OverallCompletionPercentage = u.StudentProgress.Any() ? u.StudentProgress.Average(sp => sp.CompletionPercentage) : (decimal?)null,
                OverallPerformanceScore = u.StudentProgress.Any() ? u.StudentProgress.Average(sp => sp.PerformanceScore) : (decimal?)null
            })
            .ToListAsync();

        var response = PaginatedResponseModel<List<StudentListDto>>.SuccessResponse(
            students,
            "Students retrieved successfully.",
            filter.PageNumber,
            filter.PageSize,
            totalRecords
        );

        _cache.Set(cacheKey, response, TimeSpan.FromMinutes(10));

        return response;
    }

    private string GenerateStudentCacheKey(StudentFilterDto filter)
    {
        var key = $"students:{filter.PageNumber}:{filter.PageSize}:{filter.SortBy}:{filter.SortOrder}:{filter.SearchTerm}:{filter.Grade}:{filter.SubjectId}:{filter.StartDate?.ToString("yyyyMMdd")}:{filter.EndDate?.ToString("yyyyMMdd")}";
        return key.ToLowerInvariant();
    }


    public async Task<ResponseModel<StudentDetailDto>> GetStudentByIdAsync(int studentId)
    {
        var cacheKey = $"student:{studentId}";

        if (_cache.TryGetValue(cacheKey, out ResponseModel<StudentDetailDto> cachedResult))
            return cachedResult!;

        var student = await _context.Users
            .Where(u => u.Id == studentId && u.Role == Roles.Student)
            .Include(u => u.StudentProgress)
                .ThenInclude(sp => sp.Subject) // Include Subject for progress
            .Include(u => u.StudentAssessments)
                .ThenInclude(a => a.Subject) // Include Subject for assessments
            .Include(u => u.ActivityLogs)
                .ThenInclude(al => al.Subject) // Include Subject for activity logs
            .AsNoTracking()
            .AsSplitQuery()
            .FirstOrDefaultAsync();

        if (student == null)
            return ResponseModel<StudentDetailDto>.Error(message: Messages.StudentNotFound, status: System.Net.HttpStatusCode.NotFound);

        var studentDetail = student.Adapt<StudentDetailDto>();

        var result = ResponseModel<StudentDetailDto>.SuccessResponse(studentDetail, "Student details retrieved successfully.");

        _cache.Set(cacheKey, result, TimeSpan.FromMinutes(10));

        return result;
    }

    public async Task<ResponseModel<List<StudentSubjectProgressDto>>> GetStudentProgressMetricsAsync(int studentId)
    {
        var cacheKey = $"progress:student:{studentId}";

        if (_cache.TryGetValue(cacheKey, out ResponseModel<List<StudentSubjectProgressDto>> cachedResponse))
            return cachedResponse!;

        var studentExists = await _context.Users.AnyAsync(u => u.Id == studentId && u.Role == Roles.Student);
        if (!studentExists)
            throw new NotFoundException(Messages.StudentNotFound);

        var progressList = await _context.StudentProgress
            .Where(sp => sp.StudentId == studentId)
            .Include(sp => sp.Subject)
            .ProjectToType<StudentSubjectProgressDto>() // Mapster projection
            .ToListAsync();

        if (!progressList.Any())
            return ResponseModel<List<StudentSubjectProgressDto>>.SuccessResponse(new List<StudentSubjectProgressDto>(), Messages.ProgressDataNotFound, System.Net.HttpStatusCode.NoContent);

        var response = progressList.Any()
            ? ResponseModel<List<StudentSubjectProgressDto>>.SuccessResponse(progressList, Messages.ProgressFound)
            : ResponseModel<List<StudentSubjectProgressDto>>.SuccessResponse(new List<StudentSubjectProgressDto>(), Messages.ProgressDataNotFound, System.Net.HttpStatusCode.NoContent);

        _cache.Set(cacheKey, response, TimeSpan.FromMinutes(10));

        return response;
    }

    public async Task<ResponseModel<StudentSubjectProgressDto>> UpdateStudentProgressAsync(int studentId, StudentProgressUpdateDto updateDto)
    {
        var studentProgress = await _context.StudentProgress
            .Include(sp => sp.Subject)
            .FirstOrDefaultAsync(sp => sp.StudentId == studentId && sp.SubjectId == updateDto.SubjectId);

        bool isNew = false;

        if (studentProgress == null)
        {
            studentProgress = updateDto.Adapt<StudentProgress>();
            studentProgress.StudentId = studentId;
            studentProgress.SubjectId = updateDto.SubjectId;
            studentProgress.LastActivity = DateTime.UtcNow;

            _context.StudentProgress.Add(studentProgress);
            isNew = true;
        }
        else
        {
            // Update existing fields only if provided
            if (updateDto.CompletionPercentage.HasValue)
                studentProgress.CompletionPercentage = updateDto.CompletionPercentage.Value;

            if (updateDto.PerformanceScore.HasValue)
                studentProgress.PerformanceScore = updateDto.PerformanceScore.Value;

            if (updateDto.TimeSpent.HasValue)
                studentProgress.TimeSpent = updateDto.TimeSpent.Value;

            if (updateDto.CompletedAssignments.HasValue)
                studentProgress.CompletedAssignments = updateDto.CompletedAssignments.Value;

            if (updateDto.TotalAssignments.HasValue)
                studentProgress.TotalAssignments = updateDto.TotalAssignments.Value;

            studentProgress.LastActivity = DateTime.UtcNow;
        }

        await _context.SaveChangesAsync();

        if (_cache is MemoryCache concreteMemoryCache)
            concreteMemoryCache.Clear();

        // Reload subject if newly created (in case navigation was not auto-populated)
        if (isNew || studentProgress.Subject == null)
        {
            studentProgress = await _context.StudentProgress
                .Include(sp => sp.Subject)
                .FirstOrDefaultAsync(sp => sp.Id == studentProgress.Id);
        }

        var dto = studentProgress.Adapt<StudentSubjectProgressDto>();

        return ResponseModel<StudentSubjectProgressDto>.SuccessResponse(
            dto,
            isNew
            ? "Student progress created successfully."
            : "Student progress updated successfully."
        );
    }

}
