using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic;

public class SongService(ISongRepository _songRepository) : ISongService
{
    public async Task AddSongAsync(Song song)
    {
        await _songRepository.AddAsync(song);
    }

    public async Task DeleteSongAsync(Guid songId)
    {
        await _songRepository.DeleteAsync(songId);
    }

    public async Task<Song?> GetSongByIdAsync(Guid songId)
    {
        return await _songRepository.GetByIdAsync(songId);
    }

    public async Task<IEnumerable<Song>> GetSongsAsync()
    {
        return await _songRepository.GetAsync();
    }

    public async Task UpdateSongAsync(Song newSong)
    {
        await _songRepository.UpdateAsync(newSong);
    }
}
