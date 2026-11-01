using FFMpegCore;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.BusinessLogic.Services;

public class AudioProcessingService : IAudioProcessingService
{
    public async Task<TimeSpan> GetSongDurationAsync(FileData audioFile)
    {
        var tmpPath = Path.GetTempFileName();

        try
        {
            using (var stream = audioFile.Content)
            using (var fs = new FileStream(tmpPath, FileMode.Create, FileAccess.Write))
            {
                await stream.CopyToAsync(fs);
            }

            var mediaInfo = await FFProbe.AnalyseAsync(tmpPath);

            return mediaInfo.Duration;
        }
        finally
        {
            if (File.Exists(tmpPath))
            {
                File.Delete(tmpPath);
            }
        }
    }
}
