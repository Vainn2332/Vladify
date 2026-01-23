using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.Controllers;

[Route("api/songs")]
[ApiController]
public class SongsController(ISongService _songService, IMapper _mapper) : ControllerBase
{
    [HttpPost]
    public Task<SongModel> CreateSong(
        SongRequestModel songRequestModel,
        CancellationToken cancellationToken)
    {
        return _songService.AddSongAsync(songRequestModel, cancellationToken);
    }

    [HttpGet]
    public Task<IEnumerable<SongModel>> GetAllSongs(
        [FromQuery] PaginationFilter filter,
        CancellationToken cancellationToken
        )
    {
        return _songService.GetSongsAsync(filter, cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<SongModel> GetSongById(Guid id, CancellationToken cancellationToken)
    {
        var song = await _songService.GetSongByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        return song;
    }

    [HttpPut("{id}")]
    public async Task<SongModel> UpdateSong(
        Guid id,
        SongRequestModel songRequestModel,
        CancellationToken cancellationToken)
    {
        var songModel = _mapper.Map<SongModel>(songRequestModel);
        songModel.Id = id;

        return await _songService.UpdateSongAsync(songModel, cancellationToken);
    }

    [HttpDelete("{id}")]
    public Task DeleteSong(Guid id, CancellationToken cancellationToken)
    {
        return _songService.DeleteSongAsync(id, cancellationToken);
    }
}
