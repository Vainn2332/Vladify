using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISongService
{
    public Task<SongModel?> GetSongByIdAsync(Guid songId, CancellationToken cancellationToken = default);
    public Task<IEnumerable<SongModel>> GetSongsAsync(PaginationFilter filter, CancellationToken cancellationToken = default);
    public Task<SongModel> AddSongAsync(SongRequestModel songRequestModel, CancellationToken cancellationToken = default);
    public Task<SongModel> UpdateSongAsync(SongModel SongModel, CancellationToken cancellationToken = default);
    public Task DeleteSongAsync(Guid songId, CancellationToken cancellationToken = default);
}
