using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Options;

namespace Vladify.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class ApiKeyFilter(string apiKeyName) : Attribute, IAsyncActionFilter
{
    private const string HeaderName = "X-Api-Key";

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var optionsMonitor = context.HttpContext.RequestServices.GetRequiredService<IOptionsMonitor<ApiKeysOptions>>();
        var apiKey = optionsMonitor.Get(apiKeyName).Value;

        if (!context.HttpContext.Request.Headers.TryGetValue(HeaderName, out var extractedApiKey) ||
            apiKey != extractedApiKey)
        {
            throw new UnauthorizedException("Invalid ApiKey!");
        }

        await next();
    }
}
