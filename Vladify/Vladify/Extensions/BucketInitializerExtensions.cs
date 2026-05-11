using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Options;

namespace Vladify.Extensions;

public static class BucketInitializerExtensions
{
    public async static Task ConfigureBucketsAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var minioOptions = scope.ServiceProvider.GetRequiredService<IOptions<MinioOptions>>().Value;
        var s3Client = scope.ServiceProvider.GetRequiredService<IAmazonS3>();

        await EnsureBucketExistence(s3Client, minioOptions.MusicIconBucketName, CancellationToken.None);

        await EnsureBucketExistence(s3Client, minioOptions.MusicBucketName, CancellationToken.None);
    }

    private async static Task EnsureBucketExistence(IAmazonS3 s3Client, string bucketName, CancellationToken cancellationToken)
    {
        var bucketExists = await Amazon.S3.Util.AmazonS3Util
           .DoesS3BucketExistV2Async(s3Client, bucketName);

        if (!bucketExists)
        {
            await s3Client.PutBucketAsync(bucketName, cancellationToken);
        }

        var policy = $$"""
        {
            "Version": "2012-10-17",
            "Statement": [
                {
                    "Effect": "Allow",
                    "Principal": {
                        "AWS": ["*"]
                    },
                    "Action": [
                        "s3:GetObject"
                    ],
                    "Resource": [
                        "arn:aws:s3:::{{bucketName}}/*"
                    ]
                }
            ]
        }
        """;

        var request = new PutBucketPolicyRequest
        {
            BucketName = bucketName,
            Policy = policy
        };

        await s3Client.PutBucketPolicyAsync(request, cancellationToken);
    }
}
