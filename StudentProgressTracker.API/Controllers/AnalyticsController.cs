using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProgressTracker.Application.Abstractions.Analytics;
using StudentProgressTracker.Application.DTOs.Analytics.RequestModels;
using StudentProgressTracker.Domain.Constants;

namespace StudentProgressTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnalyticsController : ControllerBase
{
    private readonly IAnalyticsService _analyticsService;

    public AnalyticsController(IAnalyticsService analyticsService)
    {
        _analyticsService = analyticsService;
    }

    [HttpGet("class-summary")]
    [Authorize(Roles = Roles.Teacher)]
    public async Task<IActionResult> GetClassSummary()
    {
        var response = await _analyticsService.GetClassSummaryAsync();
        if (!response.Success && response.Status != (int)System.Net.HttpStatusCode.NoContent)
        {
            return StatusCode(response.Status, response);
        }
        return Ok(response);
    }

    [HttpGet("progress-trends")]
    public async Task<IActionResult> GetProgressTrends([FromQuery] ProgressTrendsRequestDto request)
    {
        var response = await _analyticsService.GetProgressTrendsAsync(request);
        if (!response.Success && response.Status != (int)System.Net.HttpStatusCode.NoContent)
        {
            return StatusCode(response.Status, response);
        }
        return Ok(response);
    }
}
