using System.Diagnostics;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Options;
using Vladify.Middlewares;

namespace Vladify.UnitTests.Middlewares;

public class NetworkDelayMiddlewareTest
{
    private bool _nextCalled;

    [Fact]
    public async Task InvokeAsync_ShouldNotDelay_WhenDisabled()
    {
        var middleware = CreateMiddleware(enabled: false, delayMs: 60_000);
        var stopwatch = Stopwatch.StartNew();

        await middleware.InvokeAsync(new DefaultHttpContext());

        stopwatch.Elapsed.Should().BeLessThan(TimeSpan.FromSeconds(1));
        _nextCalled.Should().BeTrue();
    }

    [Fact]
    public async Task InvokeAsync_ShouldDelayThenCallNext_WhenEnabled()
    {
        var middleware = CreateMiddleware(enabled: true, delayMs: 200);
        var stopwatch = Stopwatch.StartNew();

        await middleware.InvokeAsync(new DefaultHttpContext());

        stopwatch.Elapsed.Should().BeGreaterThanOrEqualTo(TimeSpan.FromMilliseconds(150));
        _nextCalled.Should().BeTrue();
    }

    [Fact]
    public async Task InvokeAsync_ShouldThrowWithoutCallingNext_WhenRequestAbortedDuringDelay()
    {
        var middleware = CreateMiddleware(enabled: true, delayMs: 60_000);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMilliseconds(50));
        var context = new DefaultHttpContext { RequestAborted = cancellationTokenSource.Token };

        Func<Task> act = () => middleware.InvokeAsync(context).WaitAsync(TimeSpan.FromSeconds(5));

        await act.Should().ThrowAsync<OperationCanceledException>();
        _nextCalled.Should().BeFalse();
    }

    private NetworkDelayMiddleware CreateMiddleware(bool enabled, int delayMs)
    {
        var options = new NetworkDelayOptions { Enabled = enabled, MinDelayMs = delayMs, MaxDelayMs = delayMs };

        return new NetworkDelayMiddleware(_ =>
        {
            _nextCalled = true;

            return Task.CompletedTask;
        }, Options.Create(options));
    }
}
