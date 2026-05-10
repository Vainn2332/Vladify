using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISongService
{
    public Task<SongModel?> GetSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<SongModel>> GetSongsAsync(PaginationFilter filter, CancellationToken cancellationToken);
    public Task<IEnumerable<SongModel>> GetAllSongsOfUserAsync(Guid userId, CancellationToken cancellationToken);
    public Task<SongModel> AddSongAsync(SongRequestModel songRequestModel, CancellationToken cancellationToken);
    public Task<SongModel> UpdateSongAsync(SongUpdateDto songUpdateDto, Guid requesterId, CancellationToken cancellationToken);
    public Task DeleteSongAsync(Guid songId, Guid requesterId, CancellationToken cancellationToken);
}
