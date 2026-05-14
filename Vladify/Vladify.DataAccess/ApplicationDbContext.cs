using Bogus;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserDbConfig());
        modelBuilder.ApplyConfiguration(new SongDbConfig());

        SeedData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
#pragma warning disable S2245//indicate that this pseudorandom number is safe
        Randomizer.Seed = new Random(DataAccessLayerConstants.RandomSeedDataNumber);
#pragma warning restore S2245
        var users = new UserFaker().Generate(DataAccessLayerConstants.UserSeedDataAmount);
        var userIds = users.Select(u => u.Id).ToList();

        var songs = new SongFaker(userIds).Generate(DataAccessLayerConstants.SongSeedDataAmount);

        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Song>().HasData(songs);
    }
}
