using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.DependencyInjection;
using Vladify.DataAccess;
using Vladify.IntegrationTests.Constants;

namespace Vladify.IntegrationTests.Infrastructure;

public class DataSeeder(IServiceProvider serviceProvider)
{
    public async Task<T> SeedDataAsync<T>(T entity) where T : class
    {
        using var scope = serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task SeedDataInBlobAsync(string key, CancellationToken cancellationToken)
    {
        using var scope = serviceProvider.CreateScope();
        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();

        await s3.PutObjectAsync(new PutObjectRequest
        {
            BucketName = BootstrapConstants.TestBucket,
            Key = key,
            InputStream = new MemoryStream(new byte[] { 1, 2, 3 }),
        }, cancellationToken);
    }
}
