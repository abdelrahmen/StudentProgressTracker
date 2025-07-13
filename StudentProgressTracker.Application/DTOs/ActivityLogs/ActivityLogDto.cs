using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.ActivityLogs;

public class ActivityLogDto
{
    public int Id { get; set; }
    public string ActivityType { get; set; } = string.Empty;
    public string? Description { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime ActivityDate { get; set; }
    public string? SubjectName { get; set; } // To show subject name if available
}
