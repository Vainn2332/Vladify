using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class UserRepository(ApplicationDbContext _context) : Repository<User>(_context), IUserRepository
{
    public async Task<User?> GetByEmailAsync(string email, bool isTracking, CancellationToken cancellationToken)
    {
        var getQuery = _context.Users.AsQueryable();

        if (!isTracking)
        {
            getQuery = getQuery.AsNoTracking();
        }

        return await getQuery.FirstOrDefaultAsync(u => u.EmailAddress == email, cancellationToken);
    }
}
