using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository
{
    public Task<Song?> GetByIdAsync(Guid songId);
    public Task<IEnumerable<Song>> GetAsync(int pageNumber, int pageSize);
    public Task<Song> AddAsync(Song song);
    public Task<Song> UpdateAsync(Song Song);
    public Task DeleteAsync(Song song);
}
