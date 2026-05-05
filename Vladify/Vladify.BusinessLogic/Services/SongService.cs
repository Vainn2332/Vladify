using AutoMapper;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class SongService(ISongRepository _songRepository, IMapper _mapper) : ISongService
{
    public async Task<SongModel> AddSongAsync(SongRequestModel songRequestModel, CancellationToken cancellationToken)
    {
        var song = _mapper.Map<Song>(songRequestModel);

        var newSong = await _songRepository.AddSongAsync(song, cancellationToken);

        return _mapper.Map<SongModel>(newSong);
    }

    public async Task<SongModel?> GetSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetSongWithUserInfoByIdAsync(songId, isTracking, cancellationToken);

        return _mapper.Map<SongModel>(song);
    }

    public async Task<IEnumerable<SongModel>> GetSongsAsync(PaginationFilter filter, CancellationToken cancellationToken)
    {
        var songs = await _songRepository.GetSongsWithUserInfoByIdAsync(filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<SongModel>>(songs);
    }

    public async Task<SongModel> UpdateSongAsync(SongUpdateDto songUpdateDto, Guid requesterId, CancellationToken cancellationToken)
    {
        var song = await GetAndValidateSongAsync(songUpdateDto.Id, requesterId, cancellationToken);

        var songEntity = _mapper.Map<Song>(songUpdateDto);
        songEntity.AuthorId = song.AuthorId;

        var updatedSong = await _songRepository.UpdateSongAsync(songEntity, cancellationToken);

        return _mapper.Map<SongModel>(updatedSong);
    }

    public async Task DeleteSongAsync(Guid songId, Guid requesterId, CancellationToken cancellationToken)
    {
        var song = await GetAndValidateSongAsync(songId, requesterId, cancellationToken);

        await _songRepository.DeleteAsync(song, cancellationToken);
    }

    private async Task<Song> GetAndValidateSongAsync(Guid songId, Guid requesterId, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songId, false, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");
        if (song.AuthorId != requesterId)
        {
            throw new ForbiddenException("You don't have permissions to modify this song!");
        }

        return song;
    }
}
