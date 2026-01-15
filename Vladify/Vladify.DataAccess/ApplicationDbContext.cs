using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Song> Songs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SongDbConfig());
        modelBuilder.ApplyConfiguration(new UserDbConfig());
        base.OnModelCreating(modelBuilder);

    }
}
