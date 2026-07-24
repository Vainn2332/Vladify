using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Extensions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;
namespace Vladify.Controllers;

[Route("api/songs")]
[ApiController]
[Authorize]
public class SongsController(ISongService _songService, IUserService _userService, IMapper _mapper) : ControllerBase
{
    [HttpPost, ValidationFilter]
    public async Task<SongModel> CreateSong(
        SongRequestModel songRequestModel,
        CancellationToken cancellationToken = default)
    {
        var email = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(email, false, cancellationToken)
            ?? throw new NotFoundException("User with suc id not found!");

        var songAddDto = _mapper.Map<SongAddDto>(songRequestModel);
        songAddDto.AuthorId = user.Id;

        return await _songService.AddSongAsync(songAddDto, cancellationToken);
    }

    [HttpGet]
    public Task<IEnumerable<SongModel>> GetAllSongs(
        [FromQuery] PaginationFilter filter,
        CancellationToken cancellationToken = default
        )
    {
        return _songService.GetSongsAsync(filter, cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<SongModel> GetSongById(Guid id, CancellationToken cancellationToken = default)
    {
        var song = await _songService.GetSongByIdAsync(id, false, cancellationToken)
            ?? throw new NotFoundException("Song with such id not found!");

        return song;
    }

    [HttpPut("{id}"), ValidationFilter]
    public async Task<SongModel> UpdateSong(
        Guid id,
        UpdateSongRequestModel updateSongRequestModel,
        CancellationToken cancellationToken = default)
    {
        var songUpdateDto = _mapper.Map<SongUpdateDto>(updateSongRequestModel);
        songUpdateDto.Id = id;

        return await _songService.UpdateSongAsync(songUpdateDto, cancellationToken);
    }

    [HttpDelete("{id}")]
    public Task DeleteSong(Guid id, CancellationToken cancellationToken = default)
    {
        return _songService.DeleteSongAsync(id, cancellationToken);
    }
}
