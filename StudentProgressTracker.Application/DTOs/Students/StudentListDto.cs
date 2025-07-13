using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Students;

public class StudentListDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Grade { get; set; } = string.Empty; // Display string for grade
    public DateTime? EnrollmentDate { get; set; }
    public DateTime? LastActivityDate { get; set; } // From User model
    public decimal? OverallCompletionPercentage { get; set; } // Aggregated from StudentProgress
    public decimal? OverallPerformanceScore { get; set; } // Aggregated from StudentProgress
}
