using AutoMapper;
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
        var newSongModel = _mapper.Map<SongModel>(newSong);

        return newSongModel;
    }

    public async Task<SongModel?> GetSongByIdAsync(Guid songId)
    {
        var song = await _songRepository.GetByIdAsync(songId);
        var songModel = _mapper.Map<SongModel>(song);

        return songModel;
    }

    public async Task<IEnumerable<SongModel>> GetSongsAsync()
    {
        var songs = await _songRepository.GetAsync();

        var songModels = songs.Select(_mapper.Map<SongModel>);

        return songModels;
    }

    public async Task<SongModel> UpdateSongAsync(SongModel SongModel)
    {
        var song = _mapper.Map<Song>(SongModel);

        var updatedSong = await _songRepository.UpdateAsync(song);
        var updatedSongModel = _mapper.Map<SongModel>(updatedSong);

        return updatedSongModel;
    }

    public async Task DeleteSongAsync(Guid songId)
    {
        var song = await _songRepository.GetByIdAsync(songId);
        if (song is null)
        {
            throw new ArgumentException("Song with such Id does not exist!");
        }

        await _songRepository.DeleteAsync(song);
    }
}
