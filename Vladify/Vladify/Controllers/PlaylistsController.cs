using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Extensions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;

namespace Vladify.Controllers;

[Route("api/playlists")]
[ApiController]
[Authorize]
public class PlaylistsController(IPlaylistService _playlistService, IMapper _mapper, IUserService _userService) : ControllerBase
{
    [HttpPost, ValidationFilter]
    public async Task<PlaylistModel> CreatePlaylist(
        PlaylistAddDto playlistAddDto,
        CancellationToken cancellationToken = default
        )
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        var playlistRequestModel = _mapper.Map<PlaylistRequestModel>(playlistAddDto);
        playlistRequestModel.AuthorId = user.Id;

        return await _playlistService.AddPlaylistAsync(playlistRequestModel, cancellationToken);
    }

    [HttpPost("{playlistId}/songs/{songId}")]
    public async Task<PlaylistModel> AddSongToPlaylist(
        Guid playlistId,
        Guid songId,
        CancellationToken cancellationToken
        )
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        return await _playlistService.AddSongToPlaylistAsync(playlistId, songId, user.Id, cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<PlaylistModel> GetPlaylistById(Guid id, CancellationToken cancellationToken = default)
    {
        var playlist = await _playlistService.GetPlaylistByIdAsync(id, false, cancellationToken)
            ?? throw new NotFoundException("Playlist with such id not found!");

        return playlist;
    }

    [HttpGet]
    public async Task<IEnumerable<PlaylistModel>> GetAllPlaylistsOfUser(
        [FromQuery] PaginationFilter filter,
        Guid userId,
        CancellationToken cancellationToken = default
        )
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        return await _playlistService.GetPlaylistsOfUserAsync(user.Id, filter, cancellationToken);
    }

    [HttpDelete("{id}")]
    public async Task DeletePlaylist(Guid id, CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        await _playlistService.DeletePlaylistAsync(id, user.Id, cancellationToken);
    }

    [HttpDelete("{playlistId}/songs/{songId}")]
    public async Task<PlaylistModel> DeleteSongInPlaylist(
        Guid playlistId,
        Guid songId,
        CancellationToken cancellationToken
        )
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        return await _playlistService.DeleteSongFromPlaylistAsync(playlistId, songId, user.Id, cancellationToken);
    }
}
