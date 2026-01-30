using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IUserService
{
    public Task<UserModel?> GetUserByIdAsync(Guid userId, bool isTracking, CancellationToken cancellationToken = default);
    public Task<IEnumerable<UserModel>> GetUsersAsync(PaginationFilter filter, CancellationToken cancellationToken = default);
    public Task<UserModel> AddUserAsync(UserRequestModel userRequestModel, CancellationToken cancellationToken = default);
    public Task<UserModel> UpdateUserAsync(UserUpdateRequestModel userModel, CancellationToken cancellationToken = default);
    public Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default);
    public string HashPassword(string password);
}
