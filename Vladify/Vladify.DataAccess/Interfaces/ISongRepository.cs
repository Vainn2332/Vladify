using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository
{
    public Task<Song?> GetByIdAsync(Guid songId, CancellationToken cancellationToken = default);
    public Task<IEnumerable<Song>> GetAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    public Task<Song> AddAsync(Song song, CancellationToken cancellationToken = default);
    public Task<Song> UpdateAsync(Song Song, CancellationToken cancellationToken = default);
    public Task DeleteAsync(Song song, CancellationToken cancellationToken = default);
}
