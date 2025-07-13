using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Assessments;

public class AssessmentDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public decimal? Score { get; set; }
    public decimal MaxScore { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public decimal? PercentageScore { get; set; }
    public bool IsOverdue { get; set; }
    public string SubjectName { get; set; } = string.Empty; // To show subject name
}
