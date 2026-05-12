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

file static class ErrorMessages
{
    public const string SongNotFound = "Song with such id not found!";

    public const string UserNotFound = "User with such email not found!";
}

[Route("api/songs")]
[ApiController]
[Authorize]
public class SongsController(ISongService _songService, IMapper _mapper, IUserService _userService) : ControllerBase
{
    [HttpPost, ValidationFilter]
    public async Task<SongModel> CreateSong(
        [FromForm] SongAddDto songAddDto,
        CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException(ErrorMessages.UserNotFound);

        var songRequestModel = _mapper.Map<SongRequestModel>(songAddDto);
        songRequestModel.AuthorId = user.Id;

        return await _songService.AddSongAsync(songRequestModel, cancellationToken);
    }
    [HttpGet("recent")]
    public Task<IEnumerable<SongModel>> GetRecentlyAddedSongs([FromQuery] PaginationFilter filter, CancellationToken cancellationToken)
    {
        return _songService.GetRecentlyAddedSongsAsync(filter, cancellationToken);
    }


    [HttpGet("user/{userId}")]
    public Task<IEnumerable<SongModel>> GetAllSongsOfUser(
        Guid userId,
        CancellationToken cancellationToken = default
        )
    {
        return _songService.GetAllSongsOfUserAsync(userId, cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<SongModel> GetSongById(Guid id, CancellationToken cancellationToken = default)
    {
        var song = await _songService.GetSongByIdAsync(id, false, cancellationToken)
            ?? throw new NotFoundException(ErrorMessages.SongNotFound);

        return song;
    }

    [HttpPut("{id}"), ValidationFilter]
    public async Task<SongModel> UpdateSong(
        Guid id,
        SongUpdateRequestModel songRequestModel,
        CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException(ErrorMessages.UserNotFound);


        var songUpdateDto = _mapper.Map<SongUpdateDto>(songRequestModel);
        songUpdateDto.Id = id;

        return await _songService.UpdateSongAsync(songUpdateDto, user.Id, cancellationToken);
    }

    [HttpDelete("{id}")]
    public async Task DeleteSong(Guid id, CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException(ErrorMessages.UserNotFound);

        await _songService.DeleteSongAsync(id, user.Id, cancellationToken);
    }
}
