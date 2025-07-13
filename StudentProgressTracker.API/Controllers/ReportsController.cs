using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProgressTracker.Application.Abstractions.Reports;
using StudentProgressTracker.Application.DTOs.Reports;
using StudentProgressTracker.Domain.Constants;

namespace StudentProgressTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReportsController : ControllerBase
{
    private readonly IReportService _reportService;

    public ReportsController(IReportService reportService)
    {
        _reportService = reportService;
    }

    
    [HttpGet("student-export")]
    [Authorize(Roles = Roles.Teacher)]
    public async Task<IActionResult> ExportStudentData([FromQuery] StudentExportFilterDto filter)
    {
        var response = await _reportService.ExportStudentDataToCsvAsync(filter);

        if (!response.Success)
        {
            return StatusCode(response.Status, response);
        }

        // Return the CSV content as a file
        var fileBytes = System.Text.Encoding.UTF8.GetBytes(response.Data ?? "");
        return File(fileBytes, "text/csv", "students_data.csv");
    }
}
