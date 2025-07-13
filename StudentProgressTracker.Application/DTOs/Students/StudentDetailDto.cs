using StudentProgressTracker.Application.DTOs.ActivityLogs;
using StudentProgressTracker.Application.DTOs.Assessments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Students;

public class StudentDetailDto : StudentListDto
{
    public List<StudentSubjectProgressDto> SubjectProgresses { get; set; } = new List<StudentSubjectProgressDto>();
    public List<AssessmentDto> Assessments { get; set; } = new List<AssessmentDto>();
    public List<ActivityLogDto> ActivityLogs { get; set; } = new List<ActivityLogDto>();
}

public class StudentSubjectProgressDto
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; } = string.Empty;
    public decimal CompletionPercentage { get; set; }
    public decimal PerformanceScore { get; set; }
    public TimeSpan TimeSpent { get; set; }
    public int CompletedAssignments { get; set; }
    public int TotalAssignments { get; set; }
    public DateTime LastActivity { get; set; }
    public string ProgressStatus { get; set; } = string.Empty;
}