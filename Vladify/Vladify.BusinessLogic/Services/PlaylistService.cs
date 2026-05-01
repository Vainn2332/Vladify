using AutoMapper;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class PlaylistService(IPlaylistRepository _repository, IMapper _mapper) : IPlaylistService
{
    public async Task<PlaylistModel> AddPlaylistAsync(PlaylistRequestModel playlistRequestModel, CancellationToken cancellationToken)
    {
        var playlist = _mapper.Map<Playlist>(playlistRequestModel);

        var newPlaylist = await _repository.AddAsync(playlist, cancellationToken);

        return _mapper.Map<PlaylistModel>(newPlaylist);
    }

    public async Task<PlaylistModel?> GetPlaylistByIdAsync(Guid playlistId, bool isTracking, CancellationToken cancellationToken)
    {
        var playlist = await _repository.GetPlaylistAsync(playlistId, isTracking, cancellationToken);

        return _mapper.Map<PlaylistModel>(playlist);
    }

    public async Task<IEnumerable<PlaylistModel>> GetPlaylistsAsync(PaginationFilter filter, CancellationToken cancellationToken)
    {
        var playlists = await _repository.GetPlaylistsAsync(filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<PlaylistModel>>(playlists);
    }

    public async Task DeletePlaylistAsync(Guid playlistId, CancellationToken cancellationToken)
    {
        var playlist = await _repository.GetByIdAsync(playlistId, true, cancellationToken)
            ?? throw new NotFoundException("Playlist with such id not found!");

        await _repository.DeleteAsync(playlist, cancellationToken);
    }

}
