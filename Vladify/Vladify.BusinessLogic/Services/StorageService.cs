using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Options;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.BusinessLogic.Services;

public class StorageService(IAmazonS3 amazonS3Client, IOptions<MinioOptions> options) : IStorageService
{
    public async Task<(string audioUrl, string imageUrl)> UploadAsync(IFormFile audioFile, IFormFile imageFile, CancellationToken cancellationToken)
    {
        var audioUrl = await UploadAsync(audioFile, options.Value.MusicBucketName, cancellationToken);
        var imageUrl = await UploadAsync(imageFile, options.Value.MusicIconBucketName, cancellationToken);

        return (audioUrl, imageUrl);
    }

    private async Task<string> UploadAsync(IFormFile file, string bucketName, CancellationToken cancellationToken)
    {
        var extension = Path.GetExtension(file.FileName).ToLower();
        var uniqueFileName = $"{Guid.NewGuid()}{extension}";

        using var stream = file.OpenReadStream();

        var putRequest = new PutObjectRequest
        {
            BucketName = bucketName,
            Key = uniqueFileName,
            InputStream = stream,
            ContentType = file.ContentType,
            DisablePayloadSigning = true
        };

        await amazonS3Client.PutObjectAsync(putRequest, cancellationToken);

        return $"{options.Value.ServiceUrl}/{bucketName}/{uniqueFileName}";
    }
}
