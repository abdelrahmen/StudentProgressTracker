using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using StudentProgressTracker.Application.Abstractions.Analytics;
using StudentProgressTracker.Application.Abstractions.Auth;
using StudentProgressTracker.Application.Abstractions.Reports;
using StudentProgressTracker.Application.Abstractions.Students;
using StudentProgressTracker.Application.Services.Analytics;
using StudentProgressTracker.Application.Services.Auth;
using StudentProgressTracker.Application.Services.Reports;
using StudentProgressTracker.Application.Services.Students;
using StudentProgressTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application;

public static class DependancyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddSingleton<IPasswordHasher<User>, PasswordHasher<User>>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IAnalyticsService, AnalyticsService>();
        services.AddScoped<IReportService, ReportService>();

        #region Mappster

        var config = TypeAdapterConfig.GlobalSettings;

        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);

        TypeAdapterConfig.GlobalSettings.Default.NameMatchingStrategy(NameMatchingStrategy.Flexible);

        services.AddScoped<IMapper, ServiceMapper>();

        #endregion

        return services;
    }
}
