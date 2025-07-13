using StudentProgressTracker.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

public class Assessment: IAuditable
{
    public int Id { get; set; }

    [Required]
    public int StudentId { get; set; }

    [Required]
    public int SubjectId { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Type { get; set; } = string.Empty; // Assignment, Quiz, Test, Project

    [Column(TypeName = "decimal(5,2)")]
    public decimal? Score { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal MaxScore { get; set; }

    public DateTime? CompletedAt { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual User Student { get; set; } = null!;
    public virtual Subject Subject { get; set; } = null!;

    [NotMapped]
    public decimal? PercentageScore => Score.HasValue && MaxScore > 0 ?
        (Score.Value / MaxScore) * 100 : null;

    [NotMapped]
    public bool IsOverdue => !IsCompleted && DateTime.UtcNow > DueDate;
}
