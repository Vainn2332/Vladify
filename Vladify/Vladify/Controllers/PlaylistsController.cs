using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;

namespace Vladify.Controllers;

[Route("api/playlists")]
[ApiController]
[Authorize]
public class PlaylistsController(IPlaylistService _playlistService) : ControllerBase
{
    [HttpPost, ValidationFilter]
    public Task<PlaylistModel> CreatePlaylist(
        PlaylistRequestModel playRequestModel,
        CancellationToken cancellationToken = default
        )
    {
        return _playlistService.AddPlaylistAsync(playRequestModel, cancellationToken);
    }

    [HttpPost("{playlistId}/songs/{songId}")]
    public Task<PlaylistModel> AddSongToPlaylist(
        Guid playlistId,
        Guid songId,
        CancellationToken cancellationToken
        )
    {
        return _playlistService.AddSongToPlaylistAsync(playlistId, songId, cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<PlaylistModel> GetPlaylistById(Guid id, CancellationToken cancellationToken = default)
    {
        var playlist = await _playlistService.GetPlaylistByIdAsync(id, false, cancellationToken)
            ?? throw new NotFoundException("Playlist with such id not found!");

        return playlist;
    }

    [HttpGet]
    public Task<IEnumerable<PlaylistModel>> GetAllPlaylistsOfUser(
        [FromQuery] PaginationFilter filter,
        Guid userId,
        CancellationToken cancellationToken = default
        )
    {
        return _playlistService.GetPlaylistsOfUserAsync(userId, filter, cancellationToken);
    }

    [HttpDelete("{id}")]
    public Task DeletePlaylist(Guid id, CancellationToken cancellationToken = default)
    {
        return _playlistService.DeletePlaylistAsync(id, cancellationToken);
    }

    [HttpDelete("{playlistId}/songs/{songId}")]
    public Task<PlaylistModel> DeleteSongInPlaylist(
        Guid playlistId,
        Guid songId,
        CancellationToken cancellationToken
        )
    {
        return _playlistService.DeleteSongFromPlaylistAsync(playlistId, songId, cancellationToken);
    }
}
