using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IPlaylistService
{
    public Task<PlaylistModel> AddPlaylistAsync(PlaylistRequestModel playlistRequestModel, CancellationToken cancellationToken);
    public Task<PlaylistModel> AddSongToPlaylistAsync(Guid playlistId, Guid songId, Guid requesterId, CancellationToken cancellationToken);
    public Task<PlaylistModel?> GetPlaylistByIdAsync(Guid playlistId, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<PlaylistModel>> GetPlaylistsOfUserAsync(Guid userId, PaginationFilter filter, CancellationToken cancellationToken);
    public Task<PlaylistModel> DeleteSongFromPlaylistAsync(Guid playlistId, Guid songId, Guid requesterId, CancellationToken cancellationToken);
    public Task DeletePlaylistAsync(Guid playlistId, Guid requesterId, CancellationToken cancellationToken);
}
