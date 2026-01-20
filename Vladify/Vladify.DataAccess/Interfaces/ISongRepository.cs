using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository
{
    public Task<Song?> GetByIdAsync(Guid songId);
    public Task<IEnumerable<Song>> GetAsync();
    public Task<Song> AddAsync(Song song);
    public Task<Song> UpdateAsync(Song newSong);
    public Task DeleteAsync(Guid songId);
}
