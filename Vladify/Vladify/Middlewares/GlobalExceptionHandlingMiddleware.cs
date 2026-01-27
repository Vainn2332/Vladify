using System.Net;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;

namespace Vladify.Middlewares;

public class GlobalExceptionHandlingMiddleware(RequestDelegate _next, ILogger<GlobalExceptionHandlingMiddleware> _logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The unhandled error has occured!");

            await HandleErrorAsync(context, ex);
        }
    }

    private async Task HandleErrorAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        var statusCode = exception switch
        {
            NotFoundException => HttpStatusCode.NotFound,
            ArgumentException => HttpStatusCode.BadRequest,
            ValidationFailedException => HttpStatusCode.UnprocessableContent,
            _ => HttpStatusCode.InternalServerError
        };

        context.Response.StatusCode = (int)statusCode;

        var errorDetails = new ErrorDetails()
        {
            ErrorMessage = exception.Message,
            StatusCode = (int)statusCode
        };

        await context.Response.WriteAsJsonAsync(errorDetails);
    }
}
