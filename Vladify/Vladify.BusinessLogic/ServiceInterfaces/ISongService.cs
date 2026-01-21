using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISongService
{
    public Task<SongModel?> GetSongByIdAsync(Guid songId);
    public Task<IEnumerable<SongModel>> GetSongsAsync();
    public Task<SongModel> AddSongAsync(SongRequestModel songRequestModel);
    public Task<SongModel> UpdateSongAsync(SongModel SongModel);
    public Task DeleteSongAsync(Guid songId);
}
