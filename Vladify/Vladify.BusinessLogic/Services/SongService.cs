using AutoMapper;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class SongService(ISongRepository _songRepository, IMapper _mapper, IModerationIntegrationClient _moderationClient, IStorageService _storageService) : ISongService
{
    public async Task<SongModel> AddSongAsync(SongAddDto songAddDto, CancellationToken cancellationToken)
    {
        var song = _mapper.Map<Song>(songAddDto);
        song.Status = SongStatus.Pending;

        var newSong = _songRepository.AddWithoutSaveChanges(song);


        var audioFileUrl = $"songs/{newSong.Id}{Path.GetExtension(songAddDto.Audio.FileName)}";
        var coverFileUrl = $"covers/{newSong.Id}{Path.GetExtension(songAddDto.Cover.FileName)}";
        try
        {
            await _storageService.UploadAsync(songAddDto.Audio.Content, audioFileUrl, songAddDto.Audio.ContentType, cancellationToken);
            await _storageService.UploadAsync(songAddDto.Cover.Content, coverFileUrl, songAddDto.Cover.ContentType, cancellationToken);

            newSong.AudioUrl = audioFileUrl;
            newSong.CoverUrl = coverFileUrl;

            await _songRepository.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            await _storageService.DeleteAsync(audioFileUrl, cancellationToken);
            await _storageService.DeleteAsync(coverFileUrl, cancellationToken);

            throw;
        }

        await _moderationClient.CreateTaskAsync(newSong.Id.ToString(), cancellationToken);

        var songModel = _mapper.Map<SongModel>(newSong);
        songModel.Author = songAddDto.Author;

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

        await _storageService.DeleteAsync(song.AudioUrl, cancellationToken);
        await _storageService.DeleteAsync(song.CoverUrl, cancellationToken);

        await _songRepository.DeleteAsync(song, cancellationToken);
    }
}
