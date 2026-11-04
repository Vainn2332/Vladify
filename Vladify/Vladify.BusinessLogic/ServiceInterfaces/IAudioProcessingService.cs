namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IAudioProcessingService
{
    public Task<TimeSpan> GetSongDurationAsync(Stream audioFile);
}
