using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Fakers;

namespace Vladify.DataAccess;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Song> Songs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new SongDbConfig());
        modelBuilder.ApplyConfiguration(new UserDbConfig());

        Bogus.Randomizer.Seed = new Random(DALConstants.RandomSeedDataNumber);

        var fakeUsers = new UserFaker().Generate(10);
        var fakeSongs = new SongFaker().Generate(15);

        modelBuilder.Entity<User>().HasData(fakeUsers);
        modelBuilder.Entity<Song>().HasData(fakeSongs);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //simply doesn't work without it
        optionsBuilder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
