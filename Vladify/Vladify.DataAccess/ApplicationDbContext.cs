using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.DbConfig;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Fakers;

namespace Vladify.DataAccess;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Playlist> Playlists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserDbConfig());
        modelBuilder.ApplyConfiguration(new SongDbConfig());
        modelBuilder.ApplyConfiguration(new PlaylistDbConfig());

        //SeedData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        var users = new UserFaker().Generate(DataAccessLayerConstants.UserSeedDataAmount);
        var userIds = users.Select(u => u.Id).ToList();

        var songs = new SongFaker(userIds).Generate(DataAccessLayerConstants.SongSeedDataAmount);

        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Song>().HasData(songs);
    }
}
