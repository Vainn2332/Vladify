using Microsoft.AspNetCore.Http;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IStorageService
{
    public Task<(string audioUrl, string imageUrl)> UploadAsync(IFormFile audioFile, IFormFile imageFile, CancellationToken cancellationToken);
}
