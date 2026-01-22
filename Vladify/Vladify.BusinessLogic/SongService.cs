using AutoMapper;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic;

public class SongService(ISongRepository _songRepository, IMapper _mapper) : ISongService
{
    public async Task<SongModel> AddSongAsync(SongRequestModel songRequestModel)
    {
        var song = _mapper.Map<Song>(songRequestModel);

        var newSong = await _songRepository.AddAsync(song);

        return _mapper.Map<SongModel>(newSong);
    }

    public async Task<SongModel?> GetSongByIdAsync(Guid songId)
    {
        var song = await _songRepository.GetByIdAsync(songId);

        return _mapper.Map<SongModel>(song);
    }

    public async Task<IEnumerable<SongModel>> GetSongsAsync(PaginationFilter filter)
    {
        var songs = await _songRepository.GetAsync(filter.PageNumber, filter.PageSize);

        return _mapper.Map<IEnumerable<SongModel>>(songs);
    }

    public async Task<SongModel> UpdateSongAsync(SongModel SongModel)
    {
        var target = await GetSongByIdAsync(SongModel.Id);
        if (target is null)
        {
            throw new NotFoundException("Song with such id not found!");
        }

        var song = _mapper.Map<Song>(SongModel);

        var updatedSong = await _songRepository.UpdateAsync(song);

        return _mapper.Map<SongModel>(updatedSong);
    }

    public async Task DeleteSongAsync(Guid songId)
    {
        var song = await _songRepository.GetByIdAsync(songId);
        if (song is null)
        {
            throw new NotFoundException("Song with such id not found!");
        }

        await _songRepository.DeleteAsync(song);
    }
}
