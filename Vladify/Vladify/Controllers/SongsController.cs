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
    public async Task<ActionResult<SongModel>> CreateSong([FromBody] SongRequestModel songRequestModel)
    {
        var createdSong = await _songService.AddSongAsync(songRequestModel);

        return CreatedAtAction(nameof(GetSongById), new { Id = createdSong.Id }, createdSong);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SongModel>>> GetAllSongs([FromQuery] PaginationFilter filter)
    {
        var songs = await _songService.GetSongsAsync(filter);

        return Ok(songs);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SongModel>> GetSongById(Guid id)
    {
        var song = await _songService.GetSongByIdAsync(id);
        if (song is null)
        {
            return NotFound();
        }

        return Ok(song);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<SongModel>> UpdateSong(Guid id, [FromBody] SongRequestModel songRequestModel)
    {
        var songModel = _mapper.Map<SongModel>(songRequestModel);
        songModel.Id = id;

        var updatedSong = await _songService.UpdateSongAsync(songModel);

        return Ok(updatedSong);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<SongModel>> DeleteSong(Guid id)
    {
        await _songService.DeleteSongAsync(id);

        return NoContent();
    }
}
