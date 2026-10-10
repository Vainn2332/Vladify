using Bogus;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.DbConfig;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
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

        SeedData(modelBuilder);

        base.OnModelCreating(modelBuilder);

        modelBuilder.AddInboxStateEntity();
        modelBuilder.AddOutboxStateEntity();
        modelBuilder.AddOutboxMessageEntity();
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
        Randomizer.Seed = new Random(SeedingConstants.RandomSeedDataNumber);

        var users = new UserFaker().Generate(SeedingConstants.UserSeedDataAmount);
        var userIds = users.Select(u => u.Id);

        var songs = new SongFaker(userIds).Generate(SeedingConstants.SongSeedDataAmount);
        var approvedSongIds = songs
            .Where(s => s.Status == SongStatus.Approved)
            .Select(s => s.Id)
            .ToList();

        var playlists = new PlaylistFaker(userIds).Generate(SeedingConstants.PlaylistSeedDataAmount);

        var faker = new Faker();
        var playlistSongs = playlists
            .SelectMany(playlist =>
            {
                int songsAmount = faker.Random.Int(
                    SeedingConstants.MinSongsInSeedPlaylist,
                    Math.Min(SeedingConstants.MaxSongsInSeedPlaylist, approvedSongIds.Count));

                return faker.PickRandom(approvedSongIds, songsAmount)
                    .Select(songId => new { PlaylistsId = playlist.Id, SongsId = songId });
            })
            .ToList();

        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Song>().HasData(songs);
        modelBuilder.Entity<Playlist>().HasData(playlists);

        modelBuilder.Entity<Playlist>()
            .HasMany(p => p.Songs)
            .WithMany(s => s.Playlists)
            .UsingEntity(linkTable => linkTable.HasData(playlistSongs));
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<Enum>()
            .HaveConversion<string>();
    }
}
