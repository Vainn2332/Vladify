using AutoFixture;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess.Entities;

namespace Vladify.IntegrationTests;

public static class AutoFixtureOptions
{
    public static IFixture CreateFixture()
    {
        var fixture = new Fixture();

        fixture.Customize<Song>(builder => builder
        .With(s => s.Title, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
        .With(s => s.Author, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
        .With(s => s.Album, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
        .With(s => s.Duration, () => TimeSpan.FromMinutes(new Random().Next(TestConstants.TestDataTimeSpanValuesMinDurationInSeconds, TestConstants.TestDataTimeSpanValuesMaxDurationInMinutes)))
        );

        fixture.Customize<SongRequestModel>(builder => builder
       .With(s => s.Title, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
       .With(s => s.Author, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
       .With(s => s.Album, () => string.Join("", fixture.CreateMany<char>(TestConstants.TestDataStringValuesLength)))
       .With(s => s.Duration, () => TimeSpan.FromMinutes(new Random().Next(TestConstants.TestDataTimeSpanValuesMinDurationInSeconds, TestConstants.TestDataTimeSpanValuesMaxDurationInMinutes)))
       );

        return fixture;
    }
}
