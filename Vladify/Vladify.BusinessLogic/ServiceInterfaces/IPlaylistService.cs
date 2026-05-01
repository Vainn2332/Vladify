using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IPlaylistService
{
    public Task<PlaylistModel> AddPlaylistAsync(PlaylistRequestModel playlistRequestModel, CancellationToken cancellationToken);
    public Task<PlaylistModel?> GetPlaylistByIdAsync(Guid playlistId, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<PlaylistModel>> GetPlaylistsAsync(PaginationFilter filter, CancellationToken cancellationToken);
    public Task DeletePlaylistAsync(Guid playlistId, CancellationToken cancellationToken);
}
