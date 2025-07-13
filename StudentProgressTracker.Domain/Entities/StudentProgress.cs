using StudentProgressTracker.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

public class StudentProgress: IAuditable //student per subject
{
    public int Id { get; set; }

    [Required]
    public int StudentId { get; set; }

    [Required]
    public int SubjectId { get; set; }

    [Range(0, 100)]
    [Column(TypeName = "decimal(5,2)")]
    public decimal CompletionPercentage { get; set; }

    [Range(0, 100)]
    [Column(TypeName = "decimal(5,2)")]
    public decimal PerformanceScore { get; set; }

    public TimeSpan TimeSpent { get; set; } = TimeSpan.Zero;
    public int CompletedAssignments { get; set; }
    public int TotalAssignments { get; set; }
    public DateTime LastActivity { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual User Student { get; set; } = null!;
    public virtual Subject Subject { get; set; } = null!;

    [NotMapped]
    public decimal CompletionRate => TotalAssignments > 0 ?
        (decimal)CompletedAssignments / TotalAssignments * 100 : 0;

    [NotMapped]
    public string ProgressStatus => PerformanceScore switch
    {
        >= 90 => "Excellent",
        >= 80 => "Good",
        >= 70 => "Satisfactory",
        >= 60 => "Needs Improvement",
        _ => "Struggling"
    };
}
