using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.Controllers;

[Route("api/songs")]
[ApiController]
public class SongsController(ISongService _songService, IMapper _mapper) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<SongModel>> CreateSong(
        SongRequestModel songRequestModel,
        CancellationToken cancellationToken)
    {
        var createdSong = await _songService.AddSongAsync(songRequestModel, cancellationToken);

        return CreatedAtAction(nameof(GetSongById), new { Id = createdSong.Id }, createdSong);
    }

    [HttpGet]
    public async Task<IEnumerable<SongModel>> GetAllSongs(
        [FromQuery] PaginationFilter filter,
        CancellationToken cancellationToken
        )
    {
        var songs = await _songService.GetSongsAsync(filter, cancellationToken);

        return songs;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SongModel>> GetSongById(Guid id, CancellationToken cancellationToken)
    {
        var song = await _songService.GetSongByIdAsync(id, cancellationToken);
        if (song is null)
        {
            return NotFound();
        }

        return Ok(song);
    }

    [HttpPut("{id}")]
    public async Task<SongModel> UpdateSong(
        Guid id,
        [FromBody] SongRequestModel songRequestModel,
        CancellationToken cancellationToken)
    {
        var songModel = _mapper.Map<SongModel>(songRequestModel);
        songModel.Id = id;

        var updatedSong = await _songService.UpdateSongAsync(songModel, cancellationToken);

        return updatedSong;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<SongModel>> DeleteSong(Guid id, CancellationToken cancellationToken)
    {
        await _songService.DeleteSongAsync(id, cancellationToken);

        return NoContent();
    }
}
