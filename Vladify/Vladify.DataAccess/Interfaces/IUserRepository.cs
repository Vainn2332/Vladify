using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface IUserRepository : IRepository<User>
{
    public Task<User?> GetByEmailAsync(string email, bool isTracking, CancellationToken cancellationToken);
}
