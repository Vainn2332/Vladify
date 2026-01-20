using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISongService
{
    public Task<SongModel?> GetSongByIdAsync(Guid songId);
    public Task<IEnumerable<SongModel>> GetSongsAsync();
    public Task<SongModel> AddSongAsync(SongRequestModel songModel);
    public Task<SongModel> UpdateSongAsync(SongModel newSongModel);
    public Task DeleteSongAsync(Guid songId);
}
