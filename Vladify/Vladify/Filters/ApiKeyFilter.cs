using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System.Collections.Concurrent;
using Vladify.BusinessLogic.Exceptions;
using Vladify.Options;

namespace Vladify.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class ApiKeyFilter(string apiKeyName) : Attribute, IAsyncActionFilter
{
    private const string HeaderName = "X-Api-Key";
    private static readonly ConcurrentDictionary<string, string> _cache = new();

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var options = context.HttpContext.RequestServices.GetRequiredService<IOptions<ApiKeysOptions>>();

        var apiKey = _cache.GetOrAdd(apiKeyName, apiKeyValue =>
        {
            var propertyInfo = typeof(ApiKeysOptions).GetProperty(apiKeyName)
                ?? throw new NotFoundException($"property {apiKeyName} is not found!");
            return propertyInfo.GetValue(options.Value)?.ToString()!;
        });


        if (!context.HttpContext.Request.Headers.TryGetValue(HeaderName, out var extractedApiKey) ||
            apiKey != extractedApiKey)
        {
            throw new UnauthorizedException("Invalid ApiKey!");
        }

        await next();
    }
}
