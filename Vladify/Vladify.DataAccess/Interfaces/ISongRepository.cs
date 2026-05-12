using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository : IRepository<Song>
{
    public Task<Song> AddSongAsync(Song song, CancellationToken cancellationToken);
    public Task<IEnumerable<Song>> GetSongsOfUserAsync(Guid userId, CancellationToken cancellationToken);
    public Task<Song> UpdateSongAsync(Song song, CancellationToken cancellationToken);
    public Task<Song?> GetSongWithUserInfoByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<Song>> GetSongsWithUserInfoByIdAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
    public Task<IEnumerable<Song>> GetRecentlyAddedSongsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
}
