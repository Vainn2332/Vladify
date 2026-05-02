using AutoFixture;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.DataAccess;
using Vladify.DataAccess.Entities;

namespace Vladify.IntegrationTests.Tests;

[Collection("FixtureCollection")]
public class PlaylistControllerTest
{
    private readonly IntegrationTestInfrastructure _infrastructure;
    private readonly IFixture _fixture;

    public PlaylistControllerTest(IntegrationTestInfrastructure infrastructure)
    {
        _infrastructure = infrastructure;
        _fixture = AutoFixtureOptions.CreateFixture();
    }

    [Fact]
    public async Task CreatePlaylist_Should_SaveToDatabase_When_ValidInput()
    {
        var testUser = _fixture.Create<User>();
        var existingUser = await _infrastructure.SeedDataAsync(testUser);

        var request = _fixture.Create<PlaylistRequestModel>();
        request.AuthorId = testUser.Id;

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsJsonAsync(TestConstants.PlaylistsApiRoute, request);
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var playlistInDb = await dbContext.Playlists
            .FirstOrDefaultAsync(p => p.Id == result!.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();

        result!.Id.Should().NotBeEmpty();

        playlistInDb.Should().NotBeNull();
        playlistInDb!.Id.Should().NotBeEmpty();
        playlistInDb.AuthorId.Should().Be(existingUser.Id);
    }

    [Fact]
    public async Task AddSongToPlaylist_Should_AddSong_When_ValidInput()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());

        var song = _fixture.Create<Song>();
        song.AuthorId = testUser.Id;
        var existingSong = await _infrastructure.SeedDataAsync(song);

        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = testUser.Id;
        var existingPlaylist = await _infrastructure.SeedDataAsync(playlist);

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsync($"{TestConstants.PlaylistsApiRoute}/{existingPlaylist.Id}/songs/{existingSong.Id}", null);
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var playlistInDb = await dbContext.Playlists
            .Include(p => p.Songs)
            .FirstOrDefaultAsync(p => p.Id == existingPlaylist.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();

        playlistInDb.Should().NotBeNull();
        playlistInDb!.Songs.Should().ContainSingle(s => s.Id == existingSong.Id);
    }

    [Fact]
    public async Task GetPlaylistById_Should_ReturnPlaylist_When_ValidInput()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());
        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = testUser.Id;
        var existingPlaylist = await _infrastructure.SeedDataAsync(playlist);

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.PlaylistsApiRoute}/{existingPlaylist.Id}");
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();
        result!.Id.Should().Be(existingPlaylist.Id);
    }

    [Fact]
    public async Task GetPlaylistById_Should_ReturnNotFoundStatusCode_When_NotFound()
    {
        var invalidPlaylistId = Guid.NewGuid();
        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.PlaylistsApiRoute}/{invalidPlaylistId}");

        await _infrastructure.ResetDataAsync();

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        response.Should().NotBeNull();
    }

    [Fact]
    public async Task GetAllPlaylistsOfUser_Should_ReturnPlaylists_When_Exists()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());
        var playlist1 = _fixture.Create<Playlist>();
        playlist1.AuthorId = testUser.Id;
        await _infrastructure.SeedDataAsync(playlist1);

        var playlist2 = _fixture.Create<Playlist>();
        playlist2.AuthorId = testUser.Id;
        await _infrastructure.SeedDataAsync(playlist2);

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        var queryUrl = $"{TestConstants.PlaylistsApiRoute}?userId={testUser.Id}&PageNumber=1&PageSize=10";
        using var response = await _infrastructure.Client.GetAsync(queryUrl);
        var result = await response.Content.ReadFromJsonAsync<IEnumerable<PlaylistModel>>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();
        result.Should().NotBeNull();
        result.Count().Should().Be(2);
    }

    [Fact]
    public async Task DeletePlaylist_Should_DeletePlaylist_When_ValidInput()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());
        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = testUser.Id;
        var existingPlaylist = await _infrastructure.SeedDataAsync(playlist);

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.PlaylistsApiRoute}/{existingPlaylist.Id}");

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var oldPlaylist = await context.Playlists.FirstOrDefaultAsync(p => p.Id == existingPlaylist.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        oldPlaylist.Should().BeNull();
    }

    [Fact]
    public async Task DeleteSongInPlaylist_Should_RemoveSong_When_ValidInput()
    {
        // Arrange: Сетапим данные напрямую через контекст для установки связи Many-to-Many
        var testUser = _fixture.Create<User>();
        var song = _fixture.Create<Song>();
        song.AuthorId = testUser.Id;
        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = testUser.Id;
        playlist.Songs = new List<Song> { song }; // Привязываем песню к плейлисту

        using (var scope = _infrastructure.Factory.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await dbContext.Users.AddAsync(testUser);
            await dbContext.Songs.AddAsync(song);
            await dbContext.Playlists.AddAsync(playlist);
            await dbContext.SaveChangesAsync();
        }
        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.PlaylistsApiRoute}/{playlist.Id}/songs/{song.Id}");
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using (var scope = _infrastructure.Factory.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var updatedPlaylist = await context.Playlists
                .Include(p => p.Songs)
                .FirstOrDefaultAsync(p => p.Id == playlist.Id);

            await _infrastructure.ResetDataAsync();

            response.EnsureSuccessStatusCode();
            result.Should().NotBeNull();

            updatedPlaylist.Should().NotBeNull();
            updatedPlaylist!.Songs.Should().BeEmpty();
        }
    }
}