using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentProgressTracker.Application.Abstractions.Students;
using StudentProgressTracker.Application.DTOs.Students;
using StudentProgressTracker.Domain.Entities;

namespace StudentProgressTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetStudents([FromQuery] StudentFilterDto filter)
    {
        var response = await _studentService.GetStudentsAsync(filter);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudentById(int id)
    {
        var response = await _studentService.GetStudentByIdAsync(id);
        if (!response.Success)
        {
            return StatusCode(response.Status, response);
        }
        return Ok(response);
    }

    [HttpGet("{id}/progress")]
    public async Task<IActionResult> GetStudentProgressMetrics(int id)
    {
        var response = await _studentService.GetStudentProgressMetricsAsync(id);
        if (!response.Success && response.Status != (int)System.Net.HttpStatusCode.NoContent)
        {
            return StatusCode(response.Status, response);
        }
        return Ok(response);
    }

    public async Task<IActionResult> UpdateStudentProgress(int id, [FromBody] StudentProgressUpdateDto updateDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = await _studentService.UpdateStudentProgressAsync(id, updateDto);
        if (!response.Success)
        {
            return StatusCode(response.Status, response);
        }
        return Ok(response);
    }
}
