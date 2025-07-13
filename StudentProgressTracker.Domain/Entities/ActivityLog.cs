using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

public class ActivityLog
{
    public int Id { get; set; }

    [Required]
    public int StudentId { get; set; }

    public int? SubjectId { get; set; }

    [Required]
    [StringLength(100)]
    public string ActivityType { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
    public DateTime ActivityDate { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual User Student { get; set; } = null!;
    public virtual Subject? Subject { get; set; }
}
