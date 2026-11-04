using ATL;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.BusinessLogic.Services;

public class AudioProcessingService() : IAudioProcessingService
{
    public Task<TimeSpan> GetSongDurationAsync(Stream audioFile)
    {
        if (!audioFile.CanSeek)
        {
            throw new NotSeekableStreamException(ErrorMessageConstants.NotSeekableStream);
        }

        audioFile.Position = 0;
        var track = new Track(audioFile);
        var duration = TimeSpan.FromSeconds(track.Duration);

        audioFile.Position = 0; // reset

        return Task.FromResult(duration);
    }
}
