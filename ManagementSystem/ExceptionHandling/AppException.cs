
using System.Net;
using System.Text.Json;

namespace ManagementSystem.ExceptionHandling;

public class AppException
{
    private readonly RequestDelegate _next;
    private readonly ILogger<AppException> _logger;
    public AppException(RequestDelegate requestDelegate, ILogger<AppException> logger)
    {
        _logger = logger;
        _next = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception ex) 
    {
        context.Response.ContentType = "application/json";
        var response = context.Response;
        var errorResponse = new ErrorResponse
        {
            Success = false
        };

        switch (ex)
        {
            case InvalidTokenException exception:
                response.StatusCode = (int)HttpStatusCode.Forbidden;
                errorResponse.Message = exception.Message;
                break;
            case BadRequestException Badex:
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                errorResponse.Message = Badex.Message;
                break;
            case NotFoundException Notex:
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                errorResponse.Message = Notex.Message;
                break;
            default:
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                errorResponse.Message = "An unexpected error occurred.";
                break;
        }
        _logger.LogError(ex, ex.Message);
        var result = JsonSerializer.Serialize(errorResponse);
        await context.Response.WriteAsync(result); 
    }
}