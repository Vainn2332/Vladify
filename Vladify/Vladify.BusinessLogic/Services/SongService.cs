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

        var newSong = await _songRepository.AddAsync(song, cancellationToken);

        var songWithOwner = await _songRepository.GetSongWithUserInfoByIdAsync(newSong.Id, false, cancellationToken);

        return _mapper.Map<SongModel>(songWithOwner);
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

    public async Task<SongModel> UpdateSongAsync(SongUpdateDto songUpdateDto, CancellationToken cancellationToken)
    {
        var existingSong = await _songRepository.GetByIdAsync(songUpdateDto.Id, false, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        var song = _mapper.Map<Song>(songUpdateDto);
        song.AuthorId = existingSong.AuthorId;

        var updatedSong = await _songRepository.UpdateAsync(song, cancellationToken);

        var songWithOwner = await _songRepository.GetSongWithUserInfoByIdAsync(updatedSong.Id, false, cancellationToken);

        return _mapper.Map<SongModel>(songWithOwner);
    }

    public async Task DeleteSongAsync(Guid songId, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songId, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        await _songRepository.DeleteAsync(song, cancellationToken);
    }
}
