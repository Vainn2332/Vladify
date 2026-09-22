using Vladify.BusinessLogic.Models.Pagination;
using Vladify.BusinessLogic.Models.UserModels;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IUserService
{
    public Task<UserModel?> GetUserByEmailAsync(string userEmail, bool isTracking, CancellationToken cancellationToken);
    public Task<UserModel?> GetUserByIdAsync(Guid userId, bool isTracking, CancellationToken cancellationToken);
    public Task<PagedResponse<UserModel>> GetUsersAsync(PaginationFilter filter, CancellationToken cancellationToken);
    public Task<UserModel> AddUserAsync(UserRequestModel userRequestModel, CancellationToken cancellationToken);
    public Task<UserModel> UpdateUserAsync(UserUpdateDto userUpdateDto, Guid requesterId, CancellationToken cancellationToken);
    public Task DeleteUserAsync(Guid userId, Guid requesterId, CancellationToken cancellationToken);
}
