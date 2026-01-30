using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class UserRepository(ApplicationDbContext _context) : Repository<User>(_context), IUserRepository
{
    public async Task<User?> GetByEmailAsync(string email, bool isTracking, CancellationToken cancellationToken)
    {
        return await (isTracking ? _context.Users : _context.Users.AsNoTracking())
            .FirstOrDefaultAsync(u => u.EmailAddress == email, cancellationToken);
    }
}
