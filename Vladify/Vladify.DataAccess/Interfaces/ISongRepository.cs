using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository : IRepository<Song>
{
    public Task<Song?> GetApprovedSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken);
}
