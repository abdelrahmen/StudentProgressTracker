using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Analytics;

public class ProgressTrendDto
{
    public DateTime Date { get; set; }
    public int SubjectId { get; set; }
    public string SubjectName { get; set; } = string.Empty;
    public decimal AverageCompletion { get; set; }
    public decimal AveragePerformance { get; set; }
    public int StudentCount { get; set; }
}
