using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;
using Vladify.Options;

namespace Vladify.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController(IUserService _userService, IMapper _mapper, IOptions<ApiKeysOptions> _options, IAuth0Service _auth0Service) : ControllerBase
{
    [HttpPost, ValidationFilter]
    public Task<UserModel> CreateUser(UserRequestModel userRequestModel, [FromHeader(Name = "X-AuthApiKey")] string auth0ApiKey, CancellationToken cancellationToken = default)
    {
        if (_options.Value.Auth0SyncInDb != auth0ApiKey)
        {
            throw new UnauthorizedException("Invalid ApiKey!");
        }

        return _userService.AddUserAsync(userRequestModel, cancellationToken);
    }

    [Authorize]
    [HttpGet, ValidationFilter]
    public Task<IEnumerable<UserModel>> GetUsers(
        [FromQuery] PaginationFilter paginationFilter,
        CancellationToken cancellationToken = default)
    {
        return _userService.GetUsersAsync(paginationFilter, cancellationToken);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<UserModel> GetUserById(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _userService.GetUserByIdAsync(id, false, cancellationToken)
            ?? throw new NotFoundException("User with such id doesn't exist!");

        return user;
    }

    [Authorize]
    [HttpPut("{id}"), ValidationFilter]
    public Task<UserModel> UpdateUser(
        Guid id,
        UserUpdateRequestModel userUpdateRequestModel,
        CancellationToken cancellationToken = default)
    {
        var userUpdateDto = _mapper.Map<UserUpdateDto>(userUpdateRequestModel);
        userUpdateDto.Id = id;

        return _userService.UpdateUserAsync(userUpdateDto, cancellationToken);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task DeleteUser(Guid id, CancellationToken cancellationToken = default)
    {
        var target = await _userService.GetUserByIdAsync(id, false, cancellationToken);

        await _auth0Service.DeleteUserAsync(target!.Auth0Id);
        await _userService.DeleteUserAsync(id, cancellationToken);
    }
}
