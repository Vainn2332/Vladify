using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Extensions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;

namespace Vladify.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController(IUserService _userService, IMapper _mapper) : ControllerBase
{
    [HttpPost, ValidationFilter, ApiKeyFilter("Auth0")]
    public Task<UserModel> CreateUser(UserRequestModel userRequestModel, CancellationToken cancellationToken = default)
    {
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
    public async Task<UserModel> UpdateUser(
        Guid id,
        UserUpdateRequestModel userUpdateRequestModel,
        CancellationToken cancellationToken = default)
    {
        var userEmail = User.GetEmail();
        var user = await _userService.GetUserByEmailAsync(userEmail, false, cancellationToken)
            ?? throw new NotFoundException(BusinessLogicLayerConstants.User_NotFoundByEmail_ErrorMessage);

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
            ?? throw new NotFoundException(BusinessLogicLayerConstants.User_NotFoundByEmail_ErrorMessage);

        await _userService.DeleteUserAsync(id, user.Id, cancellationToken);
    }
}
