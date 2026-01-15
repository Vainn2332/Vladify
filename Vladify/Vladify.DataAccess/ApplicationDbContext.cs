using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess;

public class ApplicationDbContext(DbContextOptions<DbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Song> Songs { get; set; }
}
