using AutoMapper;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class PlaylistService(IPlaylistRepository _repository, ISongRepository _songRepository, IMapper _mapper) : IPlaylistService
{
    public async Task<PlaylistModel> AddPlaylistAsync(PlaylistRequestModel playlistRequestModel, CancellationToken cancellationToken)
    {
        var entityPlaylist = _mapper.Map<Playlist>(playlistRequestModel);

        var playlist = await _repository.AddAsync(entityPlaylist, cancellationToken);

        var newPlaylist = await _repository.GetPlaylistAsync(playlist.Id, false, cancellationToken);

        return _mapper.Map<PlaylistModel>(newPlaylist);
    }

    public async Task<PlaylistModel> AddSongToPlaylistAsync(Guid playlistId, Guid songId, Guid requesterId, CancellationToken cancellationToken)
    {
        var playlist = await _repository.GetPlaylistAsync(playlistId, true, cancellationToken)
            ?? throw new NotFoundException("Playlist with such id doesn't exist!");
        var song = await _songRepository.GetByIdAsync(songId, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id doesn't exist!");
        if (playlist.AuthorId != requesterId)
        {
            throw new ForbiddenException("You don't have permissions to modify this playlist!");
        }

        await _repository.AddSongToPlaylistAsync(playlist, song, cancellationToken);

        var newPlaylist = await _repository.GetPlaylistAsync(playlistId, false, cancellationToken);

        return _mapper.Map<PlaylistModel>(newPlaylist);
    }

    public async Task<PlaylistModel?> GetPlaylistByIdAsync(Guid playlistId, bool isTracking, CancellationToken cancellationToken)
    {
        var playlist = await _repository.GetPlaylistAsync(playlistId, isTracking, cancellationToken);

        return _mapper.Map<PlaylistModel>(playlist);
    }

    public async Task<IEnumerable<PlaylistModel>> GetPlaylistsOfUserAsync(Guid userId, PaginationFilter filter, CancellationToken cancellationToken)
    {
        var playlists = await _repository.GetPlaylistsOfUserAsync(userId, filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<PlaylistModel>>(playlists);
    }

    public async Task DeletePlaylistAsync(Guid playlistId, Guid requesterId, CancellationToken cancellationToken)
    {
        var playlist = await _repository.GetByIdAsync(playlistId, true, cancellationToken)
            ?? throw new NotFoundException("Playlist with such id not found!");
        if (playlist.AuthorId != requesterId)
        {
            throw new ForbiddenException("You don't have permissions to delete this playlist!");
        }

        await _repository.DeleteAsync(playlist, cancellationToken);
    }

    public async Task<PlaylistModel> DeleteSongFromPlaylistAsync(Guid playlistId, Guid songId, Guid requesterId, CancellationToken cancellationToken)
    {
        var playlist = await _repository.GetPlaylistAsync(playlistId, true, cancellationToken)
          ?? throw new NotFoundException("Playlist with such id doesn't exist!");
        var song = await _songRepository.GetByIdAsync(songId, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id doesn't exist!");
        if (playlist.AuthorId != requesterId)
        {
            throw new ForbiddenException("You don't have permissions to modify this playlist!");
        }

        await _repository.DeleteSongFromPlaylistAsync(playlist, song, cancellationToken);

        var newPlaylist = await _repository.GetPlaylistAsync(playlistId, false, cancellationToken);

        return _mapper.Map<PlaylistModel>(newPlaylist);
    }
}
