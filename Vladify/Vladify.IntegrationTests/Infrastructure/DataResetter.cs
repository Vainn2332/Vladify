using Amazon.S3;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Respawn;
using System.Data.Common;
using Vladify.IntegrationTests.Constants;

namespace Vladify.IntegrationTests.Infrastructure;

public sealed class DataResetter : IAsyncDisposable
{
    private Respawner _respawner;
    private readonly DbConnection _connection;
    private readonly IServiceProvider _serviceProvider;

    private DataResetter(string connectionString, IServiceProvider serviceProvider)
    {
        _connection = new SqlConnection(connectionString);
        _serviceProvider = serviceProvider;
    }

    public static async Task<DataResetter> CreateAsync(string connectionString, IServiceProvider serviceProvider)
    {
        var resetter = new DataResetter(connectionString, serviceProvider);
        await resetter.InitialiseAsync();

        return resetter;
    }
    public async Task ResetDataAsync()
    {
        await _respawner.ResetAsync(_connection);

        using var scope = _serviceProvider.CreateScope();
        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();
        var list = await s3.ListObjectsV2Async(new() { BucketName = BootstrapConstants.TestBucket });
        foreach (var obj in list.S3Objects ?? [])
            await s3.DeleteObjectAsync(BootstrapConstants.TestBucket, obj.Key);
    }

    private async Task InitialiseAsync()
    {
        await _connection.OpenAsync();
        _respawner = await Respawner.CreateAsync(_connection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
            SchemasToInclude = ["dbo"],
            TablesToIgnore = ["__EFMigrationsHistory"],
        });
    }

    public ValueTask DisposeAsync()
    {
        return _connection.DisposeAsync();
    }
}
