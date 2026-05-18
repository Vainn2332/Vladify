using AutoMapper;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class UserService(IUserRepository _userRepository, IAuth0Service _authService, IMapper _mapper) : IUserService
{
    public async Task<UserModel> AddUserAsync(UserRequestModel userRequestModel, CancellationToken cancellationToken)
    {
        var target = await _userRepository.GetByEmailAsync(userRequestModel.EmailAddress, false, cancellationToken);
        if (target is not null)
        {
            throw new ArgumentException("User with such email already exists!");
        }
        var user = _mapper.Map<User>(userRequestModel);

        var newUser = await _userRepository.AddAsync(user, cancellationToken);

        return _mapper.Map<UserModel>(newUser);
    }

    public async Task<UserModel?> GetUserByIdAsync(Guid userId, bool isTracking, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(userId, isTracking, cancellationToken);

        return _mapper.Map<UserModel>(user);
    }

    public async Task<IEnumerable<UserModel>> GetUsersAsync(PaginationFilter filter, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync(filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<UserModel>>(users);
    }

    public async Task<UserModel> UpdateUserAsync(UserUpdateDto userUpdateDto, Guid requesterId, CancellationToken cancellationToken)
    {
        var user = await GetAndValidateUserAsync(userUpdateDto.Id, requesterId, cancellationToken);

        var userEntity = _mapper.Map<User>(userUpdateDto);
        userEntity.ExternalId = user.ExternalId;

        var updatedUser = await _userRepository.UpdateAsync(userEntity, cancellationToken);

        return _mapper.Map<UserModel>(updatedUser);
    }

    public async Task DeleteUserAsync(Guid userId, Guid requesterId, CancellationToken cancellationToken)
    {
        var user = await GetAndValidateUserAsync(userId, requesterId, cancellationToken);

        await _authService.DeleteUserFromAuth0Async(user.ExternalId);
        await _userRepository.DeleteAsync(user, cancellationToken);
    }

    public async Task<UserModel?> GetUserByEmailAsync(string userEmail, bool isTracking, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(userEmail, isTracking, cancellationToken);

        return _mapper.Map<UserModel>(user);
    }

    private async Task<User> GetAndValidateUserAsync(Guid userId, Guid requesterId, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(userId, false, cancellationToken)
            ?? throw new NotFoundException(ErrorMessageConstants.UserNotFoundById);
        if (user.Id != requesterId)
        {
            throw new ForbiddenException(ErrorMessageConstants.UserForbidden);
        }

        return user;
    }
}
