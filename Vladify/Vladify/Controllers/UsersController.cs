using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;

namespace Vladify.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController(IUserService _userService, IMapper _mapper) : ControllerBase
{
    [HttpPost, ValidationFilter]
    public Task<UserModel> CreateUser(UserRequestModel userRequestModel, CancellationToken cancellationToken = default)
    {
        return _userService.AddUserAsync(userRequestModel, cancellationToken);
    }

    [HttpGet, ValidationFilter]
    [Authorize]
    public Task<IEnumerable<UserModel>> GetUsers(
        [FromQuery] PaginationFilter paginationFilter,
        CancellationToken cancellationToken = default)
    {
        return _userService.GetUsersAsync(paginationFilter, cancellationToken);
    }

    [HttpGet("{id}")]
    [Authorize]
    public async Task<UserModel> GetUserById(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _userService.GetUserByIdAsync(id, false, cancellationToken)
            ?? throw new NotFoundException("User with such id doesn't exist!");

        return user;
    }

    [HttpPut("{id}"), ValidationFilter]
    [Authorize]
    public Task<UserModel> UpdateUser(
        Guid id,
        UserRequestModel userRequestModel,
        CancellationToken cancellationToken = default)
    {
        var userUpdateModel = _mapper.Map<UserUpdateRequestModel>(userRequestModel);
        userUpdateModel.Id = id;

        return _userService.UpdateUserAsync(userUpdateModel, cancellationToken);
    }

    [HttpDelete("{id}")]
    [Authorize]
    public Task DeleteUser(Guid id, CancellationToken cancellationToken = default)
    {
        return _userService.DeleteUserAsync(id, cancellationToken);
    }
}
