using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.DTOs.Reports;

public class StudentExportFilterDto
{
    public string? Grade { get; set; } // Can be string to match enum name
    public int? SubjectId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? SearchTerm { get; set; }
}
