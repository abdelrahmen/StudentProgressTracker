using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Analytics;

public class ClassSummaryDto
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public int TeacherId { get; set; }
    public string TeacherName { get; set; }
    public int StudentCount { get; set; }
    public decimal AverageCompletion { get; set; }
    public decimal AveragePerformance { get; set; }
    public List<TopPerformerDto> TopPerformers { get; set; } = new();
    public DateTime? LastUpdated { get; set; }
}

public class TopPerformerDto
{
    public int StudentId { get; set; }
    public string FullName { get; set; }
    public decimal PerformanceScore { get; set; }
}

