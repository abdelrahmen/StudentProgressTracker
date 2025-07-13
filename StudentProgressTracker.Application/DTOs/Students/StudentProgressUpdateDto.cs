using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Students;

public class StudentProgressUpdateDto
{
    public int SubjectId { get; set; }
    public decimal? CompletionPercentage { get; set; }
    public decimal? PerformanceScore { get; set; }
    public TimeSpan? TimeSpent { get; set; }
    public int? CompletedAssignments { get; set; }
    public int? TotalAssignments { get; set; }
}
