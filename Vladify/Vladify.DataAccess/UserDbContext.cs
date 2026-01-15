using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User>? Users { get; set; }

    }
}
