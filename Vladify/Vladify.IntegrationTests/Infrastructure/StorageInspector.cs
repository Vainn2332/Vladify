using Amazon.S3;
using System.Net;
using Vladify.IntegrationTests.Constants;

namespace Vladify.IntegrationTests.Infrastructure;

public static class StorageInspector
{
    public static async Task<bool> CheckPresenceInBucket(IAmazonS3 s3, string url, CancellationToken cancellationToken)
    {
        try
        {
            var data = await s3.GetObjectMetadataAsync(BootstrapConstants.TestBucket, url, cancellationToken);

            return true;
        }
        catch (AmazonS3Exception e) when (e.StatusCode == HttpStatusCode.NotFound)
        {
            return false;
        }
    }
}
