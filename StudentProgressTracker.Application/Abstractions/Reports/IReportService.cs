using StudentProgressTracker.Application.DTOs.Reports;
using StudentProgressTracker.Application.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Abstractions.Reports;

public interface IReportService
{
    Task<ResponseModel<string>> ExportStudentDataToCsvAsync(StudentExportFilterDto filter);
}
