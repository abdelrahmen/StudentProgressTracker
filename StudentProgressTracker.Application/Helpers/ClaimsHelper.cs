using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Helpers;

public static class ClaimsHelper
{
    private static HttpContext GetHttpContext()
    {
        var httpContextAccessor = new HttpContextAccessor();
        return httpContextAccessor.HttpContext;
    }
    public static string? GetUserName()
    {
        var userIdentity = GetHttpContext().User.Identity as ClaimsIdentity;

        var userName = userIdentity!.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        return userName;
    }
    public static int? GetId()
    {
        var userIdentity = GetHttpContext().User.Identity as ClaimsIdentity;

        var userId = userIdentity?.FindFirst(ClaimTypes.Sid)?.Value;

        return int.TryParse(userId, out int parsedId)? parsedId : null;
    }

    public static string? GetEmail()
    {
        var userIdentity = GetHttpContext().User.Identity as ClaimsIdentity;

        var userEmail = userIdentity!.FindFirst(ClaimTypes.Email)?.Value;

        return userEmail;
    }

    public static string? GetRole()
    {
        var userIdentity = GetHttpContext().User.Identity as ClaimsIdentity;

        var roles = userIdentity?.FindAll(ClaimTypes.Role).Select(x => x.Value).ToList();

        return roles?.FirstOrDefault();
    }
}
