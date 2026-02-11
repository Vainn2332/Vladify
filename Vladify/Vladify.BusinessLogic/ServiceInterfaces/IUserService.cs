using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IUserService
{
    public Task<UserModel?> GetUserByIdAsync(Guid userId, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<UserModel>> GetUsersAsync(PaginationFilter filter, CancellationToken cancellationToken);
    public Task<UserModel> AddUserAsync(UserRequestModel userRequestModel, CancellationToken cancellationToken);
    public Task<UserModel> UpdateUserAsync(UserUpdateRequestModel userUpdateRequestModel, CancellationToken cancellationToken);
    public Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken);
}
