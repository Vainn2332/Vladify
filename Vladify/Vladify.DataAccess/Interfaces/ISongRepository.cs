using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository : IRepository<Song>
{
    public Task<Song?> GetSongWithUserInfoByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<Song>> GetSongsWithUserInfoByIdAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
}
