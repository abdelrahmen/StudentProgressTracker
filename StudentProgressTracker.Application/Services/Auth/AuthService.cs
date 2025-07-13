using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudentProgressTracker.Application.Abstractions.Auth;
using StudentProgressTracker.Application.DTOs.Auth;
using StudentProgressTracker.Application.Helpers;
using StudentProgressTracker.Application.ResponseModel;
using StudentProgressTracker.Domain.Entities;
using StudentProgressTracker.Domain.Exceptions;
using StudentProgressTracker.Domain.Resources;
using StudentProgressTracker.Infrastructure;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentProgressTracker.Application.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly IConfiguration _configuration;
    private readonly ApplicationDbContext _context;

    public AuthService(IPasswordHasher<User> passwordHasher, IConfiguration configuration, ApplicationDbContext context)
    {
        _passwordHasher = passwordHasher;
        _configuration = configuration;
        _context = context;
    }

    public async Task<ResponseModel<AuthResponse>> LoginAsync(LoginRequest request)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email.ToLower() == request.Email);

        if (user == null)
            throw new NotFoundException("user not found");

        var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);

        if (passwordVerificationResult == PasswordVerificationResult.Failed)
            throw new UnAuthorizedException("wrong email or password");

        var token = GenerateJwtToken(user);

        // Map User to UserProfileDto for the response
        var userProfile = new UserProfileDto
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Role = user.Role.ToString() // Convert enum to string
        };

        return ResponseModel<AuthResponse>.SuccessResponse(new AuthResponse { Token = token, User = userProfile });
    }

    public async Task<ResponseModel<UserProfileDto>> GetProfileAsync()
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Id == ClaimsHelper.GetId());

        if (user == null)
            throw new UnAuthorizedException(Messages.UserIdNotFound);

        return ResponseModel<UserProfileDto>.SuccessResponse(new UserProfileDto
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Role = user.Role
        });
    }

    private string GenerateJwtToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT Key not configured.")));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role), 
                new Claim(ClaimTypes.GivenName, user.FirstName), 
                new Claim(ClaimTypes.Surname, user.LastName) 
            };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(1),
            Issuer = _configuration["Jwt:Issuer"],
            Audience = _configuration["Jwt:Audience"],
            SigningCredentials = credentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
