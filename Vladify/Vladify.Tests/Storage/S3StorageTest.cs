using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Vladify.DataAccess.Extensions;
using Vladify.DataAccess.Interfaces;
using Vladify.DataAccess.Options;
using Vladify.IntegrationTests.Constants;

namespace Vladify.UnitTests.Storage;

public class S3StorageTest
{
    private const string Key = "songs/song.mp3";

    [Fact]
    public void GetPresignedUrl_Should_SignForServiceUrl_When_PublicServiceUrlNotSet()
    {
        var url = GetPresignedUrl("http://localhost:9000", null);

        url.Should().StartWith($"http://localhost:9000/{BootstrapConstants.TestBucket}/{Key}?");
    }

    [Theory]
    [InlineData("http://localhost:9000")]
    [InlineData("https://storage.example.com")]
    public void GetPresignedUrl_Should_SignForPublicServiceUrl_When_PublicServiceUrlSet(string publicServiceUrl)
    {
        var url = GetPresignedUrl(serviceUrl: "http://minio:9000", publicServiceUrl);

        url.Should().StartWith($"{publicServiceUrl}/{BootstrapConstants.TestBucket}/{Key}?");
    }

    private static string GetPresignedUrl(string serviceUrl, string? publicServiceUrl)
    {
        var services = new ServiceCollection();
        services.AddSingleton(Options.Create(new S3Options
        {
            ServiceUrl = serviceUrl,
            PublicServiceUrl = publicServiceUrl,
            AccessKey = "access-key",
            SecretKey = "secret-key",
            BucketName = BootstrapConstants.TestBucket
        }));
        services
            .AddRepositories()
            .AddS3Storage();

        using var serviceProvider = services.BuildServiceProvider();
        using var scope = serviceProvider.CreateScope();

        return scope.ServiceProvider.GetRequiredService<IStorageService>().GetPresignedUrl(Key);
    }
}
