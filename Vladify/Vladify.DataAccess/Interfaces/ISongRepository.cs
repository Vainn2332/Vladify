using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository
{
    public Task<Song?> GetByIdAsync(Guid songId, CancellationToken ct = default);
    public Task<IEnumerable<Song>> GetAsync(int pageNumber, int pageSize, CancellationToken ct = default);
    public Task<Song> AddAsync(Song song, CancellationToken ct = default);
    public Task<Song> UpdateAsync(Song Song, CancellationToken ct = default);
    public Task DeleteAsync(Song song, CancellationToken ct = default);
}
