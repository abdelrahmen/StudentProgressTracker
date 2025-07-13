using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using StudentProgressTracker.Application.Abstractions.Reports;
using StudentProgressTracker.Application.DTOs.Reports;
using StudentProgressTracker.Application.ResponseModel;
using StudentProgressTracker.Domain.Constants;
using StudentProgressTracker.Infrastructure;
using System.Text;

namespace StudentProgressTracker.Application.Services.Reports;

public class ReportService : IReportService
{
    private readonly ApplicationDbContext _context;
    private readonly IMemoryCache _cache;

    public ReportService(ApplicationDbContext context, IMemoryCache cache)
    {
        _context = context;
        _cache = cache;
    }

    public async Task<ResponseModel<string>> ExportStudentDataToCsvAsync(StudentExportFilterDto filter)
    {
        var cacheKey = BuildExportCacheKey(filter);

        if (_cache.TryGetValue(cacheKey, out ResponseModel<string> cachedCsv))
            return cachedCsv!;

        var query = _context.Users
                            .Where(u => u.Role == Roles.Student)
                            .Include(u => u.StudentProgress) // Include for aggregated data
                            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
        {
            query = query.Where(u => u.FirstName.Contains(filter.SearchTerm) ||
                                     u.LastName.Contains(filter.SearchTerm) ||
                                     u.Email.Contains(filter.SearchTerm));
        }

        if (!string.IsNullOrWhiteSpace(filter.Grade) && Enum.TryParse(filter.Grade, true, out Grade gradeEnum))
        {
            query = query.Where(u => u.Grade == gradeEnum);
        }

        if (filter.SubjectId.HasValue)
        {
            query = query.Where(u => u.StudentProgress.Any(sp => sp.SubjectId == filter.SubjectId.Value));
        }

        if (filter.StartDate.HasValue)
        {
            query = query.Where(u => u.EnrollmentDate >= filter.StartDate.Value);
        }

        if (filter.EndDate.HasValue)
        {
            query = query.Where(u => u.EnrollmentDate <= filter.EndDate.Value);
        }

        var studentsToExport = await query.ToListAsync();

        if (!studentsToExport.Any())
        {
            return ResponseModel<string>.SuccessResponse("", "No student data found for export.", System.Net.HttpStatusCode.NoContent);
        }

        // Build CSV content
        var csvBuilder = new StringBuilder();

        // CSV Header
        csvBuilder.AppendLine("Id,FirstName,LastName,Email,Grade,EnrollmentDate,LastActivityDate,OverallCompletionPercentage,OverallPerformanceScore");

        foreach (var student in studentsToExport)
        {
            var overallCompletion = student.StudentProgress.Any() ? Math.Round(student.StudentProgress.Average(sp => sp.CompletionPercentage), 2) : 0m;
            var overallPerformance = student.StudentProgress.Any() ? Math.Round(student.StudentProgress.Average(sp => sp.PerformanceScore), 2) : 0m;

            csvBuilder.AppendLine($"{student.Id},{EscapeCsv(student.FirstName)},{EscapeCsv(student.LastName)},{EscapeCsv(student.Email)},{student.Grade},{student.EnrollmentDate:yyyy-MM-dd},{student.LastActivityDate:yyyy-MM-dd},{overallCompletion},{overallPerformance}");
        }

        var response = ResponseModel<string>.SuccessResponse(csvBuilder.ToString(), "Student data exported successfully to CSV.");

        _cache.Set(cacheKey, response, TimeSpan.FromMinutes(5));

        return response;
    }

    private string EscapeCsv(string? value)
    {
        if (value == null) return "";
        // If the value contains a comma, double quote, or newline, enclose it in double quotes
        // and escape any existing double quotes by doubling them.
        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }

    private string BuildExportCacheKey(StudentExportFilterDto filter)
    {
        return $"student_export_" +
            $"{filter.Grade ?? "all"}_" +
            $"{filter.SubjectId?.ToString() ?? "all"}_" +
            $"{filter.StartDate?.ToString("yyyyMMdd") ?? "start"}_" +
            $"{filter.EndDate?.ToString("yyyyMMdd") ?? "end"}_" +
            $"{filter.SearchTerm?.Trim().ToLower() ?? "none"}";
    }
}
