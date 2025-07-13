using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

public class Subject
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual ICollection<StudentProgress> StudentProgress { get; set; } = new List<StudentProgress>();
    public virtual ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
    public virtual ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();
}
