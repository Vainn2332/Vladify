using AutoMapper;
using MassTransit;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Messages;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class SongService(ISongRepository _songRepository, IMapper _mapper, IPublishEndpoint _publishEndpoint) : ISongService
{
    public async Task<SongModel> AddSongAsync(SongAddDto songAddDto, CancellationToken cancellationToken)
    {
        var song = _mapper.Map<Song>(songAddDto);
        song.Status = ModerationStatus.Pending;

        var newSong = _songRepository.AddWithoutSaveChanges(song);

        var songModel = _mapper.Map<SongModel>(newSong);
        songModel.Author = songAddDto.Author;

        var message = _mapper.Map<SongCreatedMessage>(songModel);
        await _publishEndpoint.Publish(message, cancellationToken);

        await _songRepository.SaveChangesAsync(cancellationToken);

        return songModel;
    }

    public async Task<SongModel?> GetSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetApprovedSongByIdAsync(songId, isTracking, cancellationToken);

        return _mapper.Map<SongModel>(song);
    }

    public async Task<IEnumerable<SongModel>> GetSongsAsync(PaginationFilter filter, CancellationToken cancellationToken)
    {
        var songs = await _songRepository.GetAllAsync(filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<SongModel>>(songs);
    }

    public async Task<SongModel> UpdateSongAsync(SongUpdateDto songUpdateDto, Guid requesterId, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songUpdateDto.Id, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");
        if (song.AuthorId != requesterId)
        {
            throw new ForbiddenException(ErrorMessageConstants.SongForbidden);
        }
        _mapper.Map(songUpdateDto, song);

        var updatedSong = await _songRepository.UpdateAsync(song, cancellationToken);

        return _mapper.Map<SongModel>(updatedSong);
    }

    public async Task DeleteSongAsync(Guid songId, Guid requesterId, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songId, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");
        if (song.AuthorId != requesterId)
        {
            throw new ForbiddenException(ErrorMessageConstants.SongForbidden);
        }

        await _songRepository.DeleteAsync(song, cancellationToken);
    }
}
