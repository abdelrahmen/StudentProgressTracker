using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

public class TeacherStudent
{
    public int Id { get; set; }

    [Required]
    public int TeacherId { get; set; }

    [Required]
    public int StudentId { get; set; }

    [Required]
    public int SubjectId { get; set; }

    public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual User Teacher { get; set; } = null!;
    public virtual User Student { get; set; } = null!;
    public virtual Subject Subject { get; set; } = null!;
}
