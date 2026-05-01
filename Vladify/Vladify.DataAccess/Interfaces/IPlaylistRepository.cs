using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface IPlaylistRepository : IRepository<Playlist>
{
    public Task<Playlist?> GetPlaylistAsync(Guid id, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<Playlist>> GetPlaylistsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
}
