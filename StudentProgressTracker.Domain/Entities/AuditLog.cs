using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Domain.Entities;

// Audit Log for system changes
public class AuditLog
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Action { get; set; } // CREATE, UPDATE, DELETE

    [Required]
    [MaxLength(100)]
    public string EntityType { get; set; } // Student, Assignment, etc.

    public int? EntityId { get; set; }

    [MaxLength(2000)]
    public string OldValues { get; set; } // JSON string

    [MaxLength(2000)]
    public string NewValues { get; set; } // JSON string

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [MaxLength(45)]
    public string IpAddress { get; set; }

    [MaxLength(500)]
    public string UserAgent { get; set; }

    // Navigation properties
    public virtual User User { get; set; }
}