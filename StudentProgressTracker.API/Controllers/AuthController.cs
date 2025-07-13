using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProgressTracker.Application.Abstractions.Auth;
using StudentProgressTracker.Application.DTOs.Auth;
using System.Security.Claims;

namespace StudentProgressTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
        => Ok(await _authService.LoginAsync(request));

    [HttpGet("profile")]
    [Authorize]
    public async Task<IActionResult> GetProfile()
        => Ok(await _authService.GetProfileAsync());

}


