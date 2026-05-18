using AutoMapper;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Extensions;
using Vladify.BusinessLogic.Messages;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;

namespace Vladify.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController(IUserService _userService, IMapper _mapper, IPublishEndpoint _publishEndpoint) : ControllerBase
{
    [HttpPost, ValidationFilter, ApiKeyFilter("Auth0")]
    public async Task CreateUser(UserRequestModel userRequestModel, CancellationToken cancellationToken = default)
    {
        var response = await _userService.AddUserAsync(userRequestModel, cancellationToken);

        var message = _mapper.Map<UserCreatedMessage>(response);

        await _publishEndpoint.Publish(message);
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
    [HttpGet("{userId}")]
    public async Task<UserModel> GetUserById(Guid userId, CancellationToken cancellationToken = default)
    {
        var user = await _userService.GetUserByIdAsync(userId, false, cancellationToken)
            ?? throw new NotFoundException("User with such id doesn't exist!");

        return user;
    }

    [Authorize]
    [HttpGet("currentUser")]
    public async Task<UserModel> GetCurrentUser(CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        return user;
    }

    [Authorize]
    [HttpPut("{id}"), ValidationFilter]
    public async Task<UserModel> UpdateUser(
        Guid id,
        UserUpdateRequestModel userUpdateRequestModel,
        CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        var userUpdateDto = _mapper.Map<UserUpdateDto>(userUpdateRequestModel);
        userUpdateDto.Id = id;

        return await _userService.UpdateUserAsync(userUpdateDto, user.Id, cancellationToken);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task DeleteUser(Guid id, CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException("User with such email not found!");

        await _userService.DeleteUserAsync(id, user.Id, cancellationToken);
    }
}
