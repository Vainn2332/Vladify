using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Options;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.BusinessLogic.Services;

file static class Constraints
{
    public static readonly string[] allowedAudioExtensions = new[] { ".mp3", ".wav", ".flac" };

    public static readonly string[] allowedImageExtensions = new[] { ".jpg", ".png", ".jpeg" };
}

public class StorageService(IAmazonS3 amazonS3Client, IOptions<MinioOptions> options) : IStorageService
{
    public async Task<(string audioUrl, string imageUrl)> UploadAsync(IFormFile audioFile, IFormFile imageFile, CancellationToken cancellationToken)
    {
        var audioUrl = await UploadAudioAsync(audioFile, cancellationToken);
        var imageUrl = await UploadImageAsync(imageFile, cancellationToken);

        return (audioUrl, imageUrl);
    }

    private async Task<string> UploadAudioAsync(IFormFile audioFile, CancellationToken cancellationToken)
    {
        var extension = Path.GetExtension(audioFile.FileName).ToLower();
        if (!Constraints.allowedAudioExtensions.Contains(extension))
        {
            throw new ArgumentException("invalid format of audioFile!");
        }

        var uniqueFileName = $"{Guid.NewGuid()}{extension}";

        using var stream = audioFile.OpenReadStream();

        var putRequest = new PutObjectRequest
        {
            BucketName = options.Value.MusicBucketName,
            Key = uniqueFileName,
            InputStream = stream,
            ContentType = audioFile.ContentType,
            DisablePayloadSigning = true
        };

        await amazonS3Client.PutObjectAsync(putRequest, cancellationToken);

        return $"{options.Value.ServiceUrl}/{options.Value.MusicBucketName}/{uniqueFileName}";
    }

    private async Task<string> UploadImageAsync(IFormFile imageFile, CancellationToken cancellationToken)
    {
        var extension = Path.GetExtension(imageFile.FileName).ToLower();
        if (!Constraints.allowedImageExtensions.Contains(extension))
        {
            throw new ArgumentException("invalid format of imageFile!");
        }

        var uniqueFileName = $"{Guid.NewGuid()}{extension}";

        using var stream = imageFile.OpenReadStream();

        var putRequest = new PutObjectRequest
        {
            BucketName = options.Value.MusicIconBucketName,
            Key = uniqueFileName,
            InputStream = stream,
            ContentType = imageFile.ContentType,
            DisablePayloadSigning = true
        };

        await amazonS3Client.PutObjectAsync(putRequest, cancellationToken);

        return $"{options.Value.ServiceUrl}/{options.Value.MusicIconBucketName}/{uniqueFileName}";
    }
}
