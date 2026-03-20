using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Exceptions;
using Vladify.Options;

namespace Vladify.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class ApiKeyFilter(string apiKeyName) : Attribute, IAsyncActionFilter
{
    private const string HeaderName = "X-Api-Key";

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var options = context.HttpContext.RequestServices.GetRequiredService<IOptions<ApiKeysOptions>>();

        var property = typeof(ApiKeysOptions).GetProperty(apiKeyName)
            ?? throw new NotFoundException($"property{apiKeyName} is not found");

        var apiKey = property.GetValue(options.Value)?.ToString();

        if (!context.HttpContext.Request.Headers.TryGetValue(HeaderName, out var extractedApiKey) ||
            apiKey != extractedApiKey)
        {
            throw new UnauthorizedException("Invalid ApiKey!");
        }

        await next();
    }
}
