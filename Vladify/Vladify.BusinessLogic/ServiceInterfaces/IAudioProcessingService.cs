using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IAudioProcessingService
{
    public Task<TimeSpan> GetSongDurationAsync(FileData fileData);
}
