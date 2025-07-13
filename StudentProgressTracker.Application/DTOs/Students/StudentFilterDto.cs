using StudentProgressTracker.Domain.Constants;


namespace StudentProgressTracker.Application.DTOs.Students;

public class StudentFilterDto
{
    public string? SearchTerm { get; set; }
    public Grade? Grade { get; set; }
    public int? SubjectId { get; set; }
    public DateTime? StartDate { get; set; } // For dateRange filtering (e.g., enrollment or last activity)
    public DateTime? EndDate { get; set; }   // For dateRange filtering
    public string? SortBy { get; set; } = "name"; // "name", "progress", "lastActivity"
    public string? SortOrder { get; set; } = "asc"; // "asc", "desc"
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
