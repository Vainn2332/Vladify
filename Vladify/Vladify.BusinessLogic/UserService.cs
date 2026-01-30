using AutoMapper;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic;

public class UserService(IUserRepository _userRepository, IMapper _mapper) : IUserService
{
    public async Task<UserModel> AddUserAsync(UserRequestModel userRequestModel, CancellationToken cancellationToken = default)
    {
        var target = await _userRepository.GetByEmailAsync(userRequestModel.EmailAddress, false, cancellationToken);
        if (target is not null)
        {
            throw new ArgumentException("User with such email already exists!");
        }
        userRequestModel.Password = HashPassword(userRequestModel.Password);
        var user = _mapper.Map<User>(userRequestModel);

        var newUser = await _userRepository.AddAsync(user, cancellationToken);

        return _mapper.Map<UserModel>(newUser);
    }

    public async Task<UserModel?> GetUserByIdAsync(Guid userId, bool isTracking, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetByIdAsync(userId, isTracking, cancellationToken);

        return _mapper.Map<UserModel>(user);
    }

    public async Task<IEnumerable<UserModel>> GetUsersAsync(PaginationFilter filter, CancellationToken cancellationToken = default)
    {
        var users = await _userRepository.GetAllAsync(filter.PageNumber, filter.PageSize, cancellationToken);

        return _mapper.Map<IEnumerable<UserModel>>(users);
    }

    public async Task<UserModel> UpdateUserAsync(UserUpdateRequestModel userUpdateRequestModel, CancellationToken cancellationToken = default)
    {
        var target = await _userRepository.GetByIdAsync(userUpdateRequestModel.Id, false, cancellationToken)
            ?? throw new NotFoundException("User with such id not found!");

        userUpdateRequestModel.Password = HashPassword(userUpdateRequestModel.Password);
        var user = _mapper.Map<User>(userUpdateRequestModel);

        var updatedUser = await _userRepository.UpdateAsync(user, cancellationToken);

        return _mapper.Map<UserModel>(updatedUser);
    }

    public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetByIdAsync(userId, true, cancellationToken)
            ?? throw new NotFoundException("User with such id not found!");

        await _userRepository.DeleteAsync(user, cancellationToken);
    }

    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.EnhancedHashPassword(password);
    }
}
