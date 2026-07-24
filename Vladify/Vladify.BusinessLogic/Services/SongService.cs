using AutoMapper;
using MassTransit;
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

        var message = _mapper.Map<SongCreatedMessage>(songModel);
        await _publishEndpoint.Publish(message, cancellationToken);

        await _songRepository.SaveChangesAsync(cancellationToken);

        return songModel;
    }

    public async Task<SongModel?> GetSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songId, isTracking, cancellationToken);

        return _mapper.Map<SongModel>(song);
    }

    public async Task<IEnumerable<SongModel>> GetSongsAsync(PaginationFilter filter, CancellationToken cancellationToken)
    {
        var songs = await _songRepository.GetAllAsync(filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<SongModel>>(songs);
    }

    public async Task<SongModel> UpdateSongAsync(SongUpdateDto songUpdateDto, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songUpdateDto.Id, false, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        var songEntity = _mapper.Map<Song>(songUpdateDto);
        songEntity.Status = song.Status;

        var updatedSong = await _songRepository.UpdateAsync(songEntity, cancellationToken);

        return _mapper.Map<SongModel>(updatedSong);
    }

    public async Task DeleteSongAsync(Guid songId, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songId, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        await _songRepository.DeleteAsync(song, cancellationToken);
    }
}
