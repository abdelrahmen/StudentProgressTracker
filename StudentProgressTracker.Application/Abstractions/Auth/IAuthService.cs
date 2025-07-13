using StudentProgressTracker.Application.DTOs.Auth;
using StudentProgressTracker.Application.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Abstractions.Auth;

public interface IAuthService
{
    Task<ResponseModel<AuthResponse>> LoginAsync(LoginRequest request);
    Task<ResponseModel<UserProfileDto>> GetProfileAsync();
}
