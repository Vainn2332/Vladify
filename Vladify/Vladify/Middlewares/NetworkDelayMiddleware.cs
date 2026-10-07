using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Options;

namespace Vladify.Middlewares;

public class NetworkDelayMiddleware(RequestDelegate _next, IOptions<NetworkDelayOptions> _options)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var options = _options.Value;

        if (options.Enabled)
        {
            var delayMs = Random.Shared.Next(options.MinDelayMs, options.MaxDelayMs + 1);
            await Task.Delay(delayMs, context.RequestAborted);
        }

        await _next(context);
    }
}
