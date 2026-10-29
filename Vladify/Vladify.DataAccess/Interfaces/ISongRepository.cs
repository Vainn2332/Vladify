using Vladify.DataAccess.Dtos.Pagination;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISongRepository : IRepository<Song>
{
    public Task<Song?> GetApprovedSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken);

    public Task<PagedResult<Song>> GetSongsOfAuthorAsync(Guid authorId, bool isTracking, int pageNumber, int pageSize, CancellationToken cancellationToken);
}
