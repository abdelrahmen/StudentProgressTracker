using Microsoft.AspNetCore.Diagnostics;
using StudentProgressTracker.Application.ResponseModel;
using StudentProgressTracker.Domain.Exceptions;
using StudentProgressTracker.Domain.Resources;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace StudentProgressTracker.API;

public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
                                          Exception exception,
                                          CancellationToken cancellationToken)
    {
        var type = exception.GetType();
        var (statusCode, errorMessage) = GetExceptionType(exception);

        _logger.Log(LogLevel.Error, exception.ToString());

        httpContext.Response.StatusCode = statusCode;

        var data = httpContext.Request.Method == HttpMethod.Get.ToString() ? httpContext.Request.QueryString.ToString() : httpContext.Request.Body.ToString();

        await httpContext.Response
            .WriteAsJsonAsync(
                ResponseModel<string>
                .Error(data, errorMessage, (HttpStatusCode)statusCode),
                cancellationToken);

        return true;
    }

    private (int statusCode, string errorMessage) GetExceptionType(Exception exception)
        => exception switch
        {
            NotFoundException => ((int)HttpStatusCode.NotFound, exception.Message),
            BadRequestException => ((int)HttpStatusCode.BadRequest, exception.Message),
            ValidationException => ((int)HttpStatusCode.BadRequest, exception.Message),
            UnAuthorizedException => ((int)HttpStatusCode.Unauthorized, exception.Message),
            _ => ((int)HttpStatusCode.InternalServerError,
            Messages.Error_General)
        };
}
