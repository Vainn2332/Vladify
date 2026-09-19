using AutoFixture;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;

namespace Vladify.IntegrationTests;

public static class AutoFixtureOptions
{
    public static IFixture CreateFixture()
    {
        var fixture = new Fixture();

        fixture.Customize<Song>(builder => builder
        .With(s => s.Title, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
        .With(s => s.Album, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
        .With(s => s.Duration, () => TimeSpan.FromMinutes(new Random().Next(TestConstants.TestDataTimeSpanValuesMinDurationInSeconds, TestConstants.TestDataTimeSpanValuesMaxDurationInMinutes)))
        .With(s => s.Status, () => SongStatus.Approved)
        .With(s => s.Owner, () => null!)
        .With(s => s.Playlists, () => null!)
        );

        fixture.Customize<User>(builder => builder
       .With(s => s.EmailAddress, () => TestConstants.TestJwtEmailClaimValue)
       .With(s => s.OwnedSongs, () => null!)
       .With(s => s.Playlists, () => null!)
       );

        fixture.Customize<Playlist>(builder => builder
        .With(s => s.Owner, () => null!)
        .With(s => s.Songs, () => null!)
        );

        return fixture;
    }
}
