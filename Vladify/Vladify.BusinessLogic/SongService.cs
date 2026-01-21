using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic;

public class SongService(ISongRepository _songRepository) : ISongService
{
    public async Task<SongModel> AddSongAsync(SongRequestModel songRequestModel)
    {
        var songEntity = new Song()
        {
            Title = songRequestModel.Title,
            Album = songRequestModel.Album,
            Author = songRequestModel.Author,
            Duration = songRequestModel.Duration
        };

        var newSong = await _songRepository.AddAsync(songEntity);
        var newSongModel = new SongModel()
        {
            Id = newSong.Id,
            Title = newSong.Title,
            Album = newSong.Album,
            Author = newSong.Author,
            Duration = newSong.Duration
        };

        return newSongModel;
    }

    public async Task<SongModel?> GetSongByIdAsync(Guid songId)
    {
        var song = await _songRepository.GetByIdAsync(songId);
        var songModel = new SongModel()
        {
            Id = song.Id,
            Title = song.Title,
            Album = song.Album,
            Author = song.Author,
            Duration = song.Duration
        };

        return songModel;
    }

    public async Task<IEnumerable<SongModel>> GetSongsAsync()
    {
        var songs = await _songRepository.GetAsync();

        var songModels = songs.Select(s => new SongModel()
        {
            Id = s.Id,
            Title = s.Title,
            Album = s.Album,
            Author = s.Author,
            Duration = s.Duration
        });

        return songModels;
    }

    public async Task<SongModel> UpdateSongAsync(SongModel SongModel)
    {
        var Song = new Song()
        {
            Id = SongModel.Id,
            Title = SongModel.Title,
            Album = SongModel.Album,
            Author = SongModel.Author,
            Duration = SongModel.Duration
        };

        var updatedSong = await _songRepository.UpdateAsync(Song);
        var updatedSongModel = new SongModel()
        {
            Id = updatedSong.Id,
            Title = updatedSong.Title,
            Album = updatedSong.Album,
            Author = updatedSong.Author,
            Duration = updatedSong.Duration
        };

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
