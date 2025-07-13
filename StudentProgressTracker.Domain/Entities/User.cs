using StudentProgressTracker.Domain.Constants;
using StudentProgressTracker.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

public class User : IAuditable
{
    public int Id { get; set; }

    [Required]
    [StringLength(256)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    public string Role { get; set; } = string.Empty;

    // Student-specific properties (nullable for non-students)
    public Grade? Grade { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    // Common properties
    public DateTime? LastActivityDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual ICollection<StudentProgress> StudentProgress { get; set; } = new List<StudentProgress>();
    public virtual ICollection<TeacherStudent> TeacherAssignments { get; set; } = new List<TeacherStudent>();
    public virtual ICollection<TeacherStudent> StudentAssignments { get; set; } = new List<TeacherStudent>();
    public virtual ICollection<Assessment> StudentAssessments { get; set; } = new List<Assessment>();
    public virtual ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();

    // Computed properties
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    [NotMapped]
    public bool IsStudent => Role == Roles.Student;

    [NotMapped]
    public bool IsTeacher => Role == Roles.Teacher;
}
