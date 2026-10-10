using AutoFixture;
using FluentAssertions;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
using Vladify.IntegrationTests.Constants;
using Vladify.IntegrationTests.Infrastructure;

namespace Vladify.IntegrationTests.Tests;

[Collection("FixtureCollection")]
public class SearchControllerTest
{
    private readonly IntegrationTestInfrastructure _infrastructure;
    private readonly IFixture _fixture;

    public SearchControllerTest(IntegrationTestInfrastructure infrastructure)
    {
        _infrastructure = infrastructure;
        _fixture = AutoFixtureOptions.CreateFixture();
    }

    [Fact]
    public async Task Search_ShouldReturnMatchingSongs_Playlists_AndUsers()
    {
        var marker = Guid.NewGuid().ToString()[..12];

        var approvedSong = _fixture.Create<Song>();
        approvedSong.Title = $"{marker} approved";

        var pendingSong = _fixture.Create<Song>();
        pendingSong.Title = $"{marker} pending";
        pendingSong.Status = SongStatus.Pending;

        var playlist = _fixture.Create<Playlist>();
        playlist.Name = $"{marker} playlist";

        var user = _fixture.Create<User>();
        user.Name = $"{marker} user";
        user.OwnedSongs = new List<Song>() { approvedSong, pendingSong };
        user.Playlists = new List<Playlist>() { playlist };

        await _infrastructure.DataSeeder.SeedDataAsync(user);

        var token = JwtBuilder.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SearchApiRoute}?query={marker.ToUpperInvariant()}");
        var result = await response.Content.ReadFromJsonAsync<SearchResult>();

        await _infrastructure.DataResetter.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();

        result.Songs.Should().ContainSingle(s => s.Id == approvedSong.Id);
        result.Songs.Should().NotContain(s => s.Id == pendingSong.Id);
        result.Playlists.Should().Contain(p => p.Id == playlist.Id);
        result.Users.Should().Contain(u => u.Id == user.Id);

    }

    [Theory]
    [InlineData("")]
    [InlineData("a")]
    public async Task Search_Should_ReturnUnprocessableEntity_WhenQueryIsInvalid(string query)
    {
        var token = JwtBuilder.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SearchApiRoute}?query={query}");

        response.StatusCode.Should().Be(HttpStatusCode.UnprocessableEntity);
    }
}
