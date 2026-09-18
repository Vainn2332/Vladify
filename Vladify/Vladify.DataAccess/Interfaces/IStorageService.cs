namespace Vladify.DataAccess.Interfaces;

public interface IStorageService
{
    public Task UploadAsync(Stream file, string key, string contentType, CancellationToken cancellationToken);

    public string GetPresignedUrl(string key, TimeSpan expiration);

    public Task DeleteAsync(string url, CancellationToken cancellationToken);
}
