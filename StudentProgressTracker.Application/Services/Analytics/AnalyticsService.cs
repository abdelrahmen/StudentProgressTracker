using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using StudentProgressTracker.Application.Abstractions.Analytics;
using StudentProgressTracker.Application.DTOs.Analytics;
using StudentProgressTracker.Application.DTOs.Analytics.RequestModels;
using StudentProgressTracker.Application.Helpers;
using StudentProgressTracker.Application.ResponseModel;
using StudentProgressTracker.Domain.Constants;
using StudentProgressTracker.Domain.Exceptions;
using StudentProgressTracker.Domain.Resources;
using StudentProgressTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Services.Analytics;

public class AnalyticsService : IAnalyticsService
{
    private readonly ApplicationDbContext _context;
    private readonly IMemoryCache _cache;

    public AnalyticsService(ApplicationDbContext context, IMemoryCache cache)
    {
        _context = context;
        _cache = cache;
    }

    public async Task<ResponseModel<List<ClassSummaryDto>>> GetClassSummaryAsync()
    {
        const string cacheKey = "class_summary";

        if (_cache.TryGetValue(cacheKey, out ResponseModel<List<ClassSummaryDto>> cachedSummary))
        {
            return cachedSummary;
        }

        var data = await _context.TeacherStudents
            .Where(ts => ts.IsActive)
            .GroupBy(ts => new { ts.TeacherId, ts.SubjectId })
            .Select(group => new ClassSummaryDto
            {
                SubjectId = group.Key.SubjectId,
                SubjectName = group.Select(x => x.Subject.Name).FirstOrDefault(),
                TeacherId = group.Key.TeacherId,
                TeacherName = group.Select(x => x.Teacher.FullName).FirstOrDefault(),
                StudentCount = group.Select(x => x.StudentId).Distinct().Count(),
                AverageCompletion = _context.StudentProgress
                    .Where(sp => group.Select(x => x.StudentId).Contains(sp.StudentId) &&
                                 sp.SubjectId == group.Key.SubjectId)
                    .Average(sp => (decimal?)sp.CompletionPercentage) ?? 0,
                AveragePerformance = _context.StudentProgress
                    .Where(sp => group.Select(x => x.StudentId).Contains(sp.StudentId) &&
                                 sp.SubjectId == group.Key.SubjectId)
                    .Average(sp => (decimal?)sp.PerformanceScore) ?? 0,
                TopPerformers = _context.StudentProgress
                    .Where(sp => group.Select(x => x.StudentId).Contains(sp.StudentId) &&
                                 sp.SubjectId == group.Key.SubjectId)
                    .OrderByDescending(sp => sp.PerformanceScore)
                    .Take(3)
                    .Select(sp => new TopPerformerDto
                    {
                        StudentId = sp.StudentId,
                        FullName = sp.Student.FullName,
                        PerformanceScore = sp.PerformanceScore
                    }).ToList(),
                LastUpdated = _context.StudentProgress
                    .Where(sp => group.Select(x => x.StudentId).Contains(sp.StudentId) &&
                                 sp.SubjectId == group.Key.SubjectId)
                    .Max(sp => (DateTime?)sp.UpdatedAt)
            })
            .ToListAsync();


        var response = ResponseModel<List<ClassSummaryDto>>.SuccessResponse(data);

        _cache.Set(cacheKey, response, new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
        });

        return response;
    }

    public async Task<ResponseModel<List<ProgressTrendDto>>> GetProgressTrendsAsync(ProgressTrendsRequestDto request)
    {
        var start = request.StartDate ?? DateTime.UtcNow.AddDays(-30);
        var end = request.EndDate ?? DateTime.UtcNow;

        var cacheKey = $"progress_trends_{start:yyyyMMdd}_{end:yyyyMMdd}_{request.SubjectId?.ToString() ?? "all"}";

        // ✅ Try to get cached response
        if (_cache.TryGetValue(cacheKey, out ResponseModel<List<ProgressTrendDto>> cachedResult))
        {
            return cachedResult;
        }

        var query = _context.StudentProgress
            .Where(sp => sp.LastActivity >= start && sp.LastActivity <= end);

        if (request.SubjectId.HasValue)
        {
            query = query.Where(sp => sp.SubjectId == request.SubjectId.Value);
        }

        var result = await query
            .GroupBy(sp => new { Date = sp.LastActivity.Date, sp.SubjectId, sp.Subject.Name })
            .Select(g => new ProgressTrendDto
            {
                Date = g.Key.Date,
                SubjectId = g.Key.SubjectId,
                SubjectName = g.Key.Name,
                AverageCompletion = g.Average(sp => sp.CompletionPercentage),
                AveragePerformance = g.Average(sp => sp.PerformanceScore),
                StudentCount = g.Select(sp => sp.StudentId).Distinct().Count()
            })
            .OrderBy(d => d.Date)
            .ToListAsync();

        var response = ResponseModel<List<ProgressTrendDto>>.SuccessResponse(result);

        _cache.Set(cacheKey, response, new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
        });

        return response;
    }

}
