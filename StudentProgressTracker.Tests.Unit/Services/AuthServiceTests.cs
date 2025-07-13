using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using StudentProgressTracker.Application.DTOs.Auth;
using StudentProgressTracker.Application.Services.Auth;
using StudentProgressTracker.Domain.Constants;
using StudentProgressTracker.Domain.Entities;
using StudentProgressTracker.Domain.Exceptions;
using StudentProgressTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Tests.Unit.Services;

public class AuthServiceTests
{
    private readonly AuthService _authService;
    private readonly Mock<IPasswordHasher<User>> _passwordHasherMock = new();
    private readonly IConfiguration _configuration;
    private readonly ApplicationDbContext _context;

    public AuthServiceTests()
    {
        // Use in-memory config
        var inMemorySettings = new Dictionary<string, string>
        {
            { "Jwt:Key", "MySuperSecretKeyForJwtTestsMySuperSecretKeyForJwtTests" },
            { "Jwt:Issuer", "TestIssuer" },
            { "Jwt:Audience", "TestAudience" }
        };

        _configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();

        // Use in-memory database
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new ApplicationDbContext(options);

        _authService = new AuthService(_passwordHasherMock.Object, _configuration, _context);
    }

    [Fact]
    public async Task LoginAsync_ShouldReturnToken_WhenCredentialsAreValid()
    {
        // Arrange
        var user = new User
        {
            Id = 1,
            Email = "test@example.com",
            FirstName = "Test",
            LastName = "User",
            Role = Roles.Teacher,
            PasswordHash = "hashed-password"
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        _passwordHasherMock
            .Setup(ph => ph.VerifyHashedPassword(user, user.PasswordHash, "password123"))
            .Returns(PasswordVerificationResult.Success);

        var request = new LoginRequest
        {
            Email = "test@example.com",
            Password = "password123"
        };

        // Act
        var result = await _authService.LoginAsync(request);

        // Assert
        result.Should().NotBeNull();
        result.Success.Should().BeTrue();
        result.Data.Token.Should().NotBeNullOrEmpty();
        result.Data.User.Email.Should().Be("test@example.com");
    }

    [Fact]
    public async Task LoginAsync_ShouldThrowNotFoundException_WhenUserNotFound()
    {
        // Arrange
        var request = new LoginRequest
        {
            Email = "unknown@example.com",
            Password = "password123"
        };

        // Act
        var act = async () => await _authService.LoginAsync(request);

        // Assert
        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("user not found");
    }

    [Fact]
    public async Task LoginAsync_ShouldThrowUnAuthorizedException_WhenPasswordInvalid()
    {
        // Arrange
        var user = new User
        {
            Id = 2,
            Email = "fail@example.com",
            FirstName = "Fail",
            LastName = "User",
            Role = Roles.Student,
            PasswordHash = "hashed-password"
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        _passwordHasherMock
            .Setup(ph => ph.VerifyHashedPassword(user, user.PasswordHash, "wrongpassword"))
            .Returns(PasswordVerificationResult.Failed);

        var request = new LoginRequest
        {
            Email = "fail@example.com",
            Password = "wrongpassword"
        };

        // Act
        var act = async () => await _authService.LoginAsync(request);

        // Assert
        await act.Should().ThrowAsync<UnAuthorizedException>()
            .WithMessage("wrong email or password");
    }
}
