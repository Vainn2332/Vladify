using AutoMapper;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic;

public class SongService(IRepository<Song> _songRepository, IMapper _mapper) : ISongService
{
    public async Task<SongModel> AddSongAsync(SongRequestModel songRequestModel, CancellationToken cancellationToken)
    {
        var song = _mapper.Map<Song>(songRequestModel);

        var newSong = await _songRepository.AddAsync(song, cancellationToken);

        return _mapper.Map<SongModel>(newSong);
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

    public async Task<SongModel> UpdateSongAsync(SongModel SongModel, CancellationToken cancellationToken)
    {
        _ = await GetSongByIdAsync(SongModel.Id, false, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        var song = _mapper.Map<Song>(SongModel);

        var updatedSong = await _songRepository.UpdateAsync(song, cancellationToken);

        return _mapper.Map<SongModel>(updatedSong);
    }

    public async Task DeleteSongAsync(Guid songId, CancellationToken cancellationToken)
    {
        var song = await _songRepository.GetByIdAsync(songId, true, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        await _songRepository.DeleteAsync(song, cancellationToken);
    }
}
