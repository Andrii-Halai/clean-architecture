using System.Text.Json;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.WebAPI.Middleware;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (NotFoundException ex)
        {
            _logger.LogInformation(ex, "Resource not found");
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            context.Response.ContentType = "application/json";

            var payload = new
            {
                error = "NotFound",
                message = ex.Message
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(payload));
        }
        catch (DomainValidationException ex)
        {
            _logger.LogWarning(ex, "Domain validation failed");
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Response.ContentType = "application/json";

            var payload = new
            {
                error = "ValidationError",
                message = ex.Message
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(payload));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception");
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            var payload = new
            {
                error = "InternalServerError",
                message = "An unexpected error occurred."
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(payload));
        }
    }
}
