using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISongService
{
    public Task<Song?> GetSongByIdAsync(Guid songId);
    public Task<IEnumerable<Song>> GetSongsAsync();
    public Task AddSongAsync(Song song);
    public Task UpdateSongAsync(Song newSong);
    public Task DeleteSongAsync(Guid songId);
}
