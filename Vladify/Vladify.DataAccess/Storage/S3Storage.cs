using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Options;
using Vladify.DataAccess.Interfaces;
using Vladify.DataAccess.Options;

namespace Vladify.DataAccess.Storage;

public class S3Storage(IAmazonS3 _s3Client, IOptions<S3Options> _options) : IStorageService
{
    private readonly string _bucket = _options.Value.BucketName;

    public async Task UploadAsync(Stream file, string key, string contentType, CancellationToken cancellationToken)
    {

        await _s3Client.PutObjectAsync(new PutObjectRequest
        {
            BucketName = _bucket,
            Key = key,
            InputStream = file,
            ContentType = contentType,
        }, cancellationToken);

    }

    public string GetPresignedUrl(string key, TimeSpan expiration)
    {
        return _s3Client.GetPreSignedURL(new GetPreSignedUrlRequest
        {
            BucketName = _bucket,
            Key = key,
            Expires = DateTime.UtcNow.Add(expiration)
        });
    }

    public Task DeleteAsync(string key, CancellationToken cancellationToken)
    {
        return _s3Client.DeleteObjectAsync(new DeleteObjectRequest
        {
            BucketName = _bucket,
            Key = key
        }, cancellationToken);
    }
}
