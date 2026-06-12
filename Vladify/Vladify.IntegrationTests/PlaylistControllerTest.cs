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

namespace Vladify.IntegrationTests;

[Collection("FixtureCollection")]
public class PlaylistsControllerTest
{
    private readonly IntegrationTestInfrastructure _infrastructure;
    private readonly IFixture _fixture;

    public PlaylistsControllerTest(IntegrationTestInfrastructure infrastructure)
    {
        _infrastructure = infrastructure;
        _fixture = AutoFixtureOptions.CreateFixture();
    }

    [Fact]
    public async Task CreatePlaylist_ShouldSaveToDatabase_WhenValidInput()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());

        var dto = _fixture.Create<PlaylistAddDto>();

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsJsonAsync(TestConstants.PlaylistsApiRoute, dto);
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var playlistInDb = await dbContext.Playlists
            .FirstOrDefaultAsync(p => p.Name == dto.Name && p.AuthorId == testUser.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();
        result!.Id.Should().NotBeEmpty();
        result.Name.Should().Be(dto.Name);

        playlistInDb.Should().NotBeNull();
        playlistInDb!.Id.Should().Be(result.Id);
        playlistInDb.Name.Should().Be(dto.Name);
    }

    [Fact]
    public async Task AddSongToPlaylist_Should_LinkSong_When_ValidInput()
    {
        var testUser = _fixture.Create<User>();

        var song = _fixture.Create<Song>();
        song.AuthorId = testUser.Id;

        var playlist = _fixture.Create<Playlist>();
        playlist.Songs = new List<Song>() { song };
        testUser.Playlists = new List<Playlist>() { playlist };

        var existingUser = await _infrastructure.SeedDataAsync(testUser);

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var url = $"{TestConstants.PlaylistsApiRoute}/{playlist.Id}/songs/{song.Id}";
        using var response = await _infrastructure.Client.PostAsync(url, null);
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var updatedPlaylistInDb = await dbContext.Playlists
            .Include(p => p.Songs)
            .FirstOrDefaultAsync(p => p.Id == playlist.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();
        updatedPlaylistInDb.Should().NotBeNull();
        updatedPlaylistInDb!.Songs.Should().Contain(s => s.Id == song.Id);
    }

    [Fact]
    public async Task GetPlaylistById_Should_ReturnPlaylist_When_Found()
    {
        var user = _fixture.Create<User>();
        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = user.Id;
        user.Playlists = new List<Playlist>() { playlist };

        var testUser = await _infrastructure.SeedDataAsync(user);

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.PlaylistsApiRoute}/{playlist.Id}");
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();
        result!.Id.Should().Be(playlist.Id);
        result.Name.Should().Be(playlist.Name);
    }

    [Fact]
    public async Task GetPlaylistById_Should_ReturnNotFound_When_NotExists()
    {
        var invalidId = Guid.NewGuid();
        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.PlaylistsApiRoute}/{invalidId}");

        await _infrastructure.ResetDataAsync();

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task GetAllPlaylistsOfUser_Should_ReturnPagedPlaylists_When_ValidInput()
    {
        var user = _fixture.Create<User>();
        var playlist1 = _fixture.Create<Playlist>();
        playlist1.AuthorId = user.Id;
        var playlist2 = _fixture.Create<Playlist>();
        playlist2.AuthorId = user.Id;
        user.Playlists = new List<Playlist>() { playlist1, playlist2 };

        var testUser = await _infrastructure.SeedDataAsync(user);

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.PlaylistsApiRoute}?PageNumber=1&PageSize=10");
        var result = await response.Content.ReadFromJsonAsync<IEnumerable<PlaylistModel>>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();
        result.Should().HaveCount(2);
    }

    [Fact]
    public async Task UpdatePlaylist_Should_UpdateData_When_ValidInput()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());
        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = testUser.Id;
        var existingPlaylist = await _infrastructure.SeedDataAsync(playlist);

        var updateDto = _fixture.Create<PlaylistUpdateDto>();

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PutAsJsonAsync($"{TestConstants.PlaylistsApiRoute}/{existingPlaylist.Id}", updateDto);
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var playlistInDb = await dbContext.Playlists.FindAsync(existingPlaylist.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();
        result!.Name.Should().Be(updateDto.Name);

        playlistInDb.Should().NotBeNull();
        playlistInDb!.Name.Should().Be(updateDto.Name);
    }

    [Fact]
    public async Task DeletePlaylist_Should_RemoveFromDatabase_When_ValidInput()
    {
        var testUser = await _infrastructure.SeedDataAsync(_fixture.Create<User>());
        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = testUser.Id;
        var existingPlaylist = await _infrastructure.SeedDataAsync(playlist);

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.PlaylistsApiRoute}/{existingPlaylist.Id}");

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var playlistInDb = await dbContext.Playlists.FindAsync(existingPlaylist.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        playlistInDb.Should().BeNull();
    }

    [Fact]
    public async Task DeleteSongInPlaylist_Should_UnlinkSong_When_ValidInput()
    {
        var user = _fixture.Create<User>();

        var song = _fixture.Create<Song>();
        song.AuthorId = user.Id;
        user.OwnedSongs = new List<Song>() { song };

        var playlist = _fixture.Create<Playlist>();
        playlist.AuthorId = user.Id;
        playlist.Songs = new List<Song> { song };

        user.Playlists = new List<Playlist>() { playlist };

        var testUser = await _infrastructure.SeedDataAsync(user);

        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var url = $"{TestConstants.PlaylistsApiRoute}/{playlist.Id}/songs/{song.Id}";
        using var response = await _infrastructure.Client.DeleteAsync(url);
        var result = await response.Content.ReadFromJsonAsync<PlaylistModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var updatedPlaylistInDb = await dbContext.Playlists
            .Include(p => p.Songs)
            .FirstOrDefaultAsync(p => p.Id == playlist.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        result.Should().NotBeNull();

        updatedPlaylistInDb.Should().NotBeNull();
        updatedPlaylistInDb!.Songs.Should().NotContain(s => s.Id == song.Id);
    }
}
