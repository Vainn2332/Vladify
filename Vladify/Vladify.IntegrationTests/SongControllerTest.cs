using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess;
using Vladify.DataAccess.Entities;
namespace Vladify.IntegrationTests;

public class SongControllerTest : IClassFixture<IntegrationTestInfrastructure>
{
    private readonly IntegrationTestInfrastructure _infrastructure;

    public SongControllerTest(IntegrationTestInfrastructure infrastructure)
    {
        _infrastructure = infrastructure;
    }

    [Fact]
    public async Task AddSongAsync_Should_SaveToDatabase_When_ValidInput()
    {
        var request = new SongRequestModel
        {
            Album = "ENMY",
            Title = "Clarity",
            Author = "ENMY",
            Duration = TimeSpan.FromMinutes(8)
        };
        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsJsonAsync(TestConstants.SongsApiRoute, request);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var songInDb = await dbContext.Songs
            .FirstOrDefaultAsync(s => s.Title == "Clarity");

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();

        result!.Album.Should().Be(request.Album);
        result!.Id.Should().NotBeEmpty();

        songInDb.Should().NotBeNull();
        songInDb!.Id.Should().NotBeEmpty();
        songInDb.Title.Should().Be(request.Title);
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnSong_When_ValidInput()
    {
        var existingSong = await _infrastructure.SeedDataAsync(new Song()
        {
            Id = Guid.NewGuid(),
            Title = "Playing w fire",
            Album = "Slow Burn",
            Author = "Conquer Divide",
            Duration = TimeSpan.FromMinutes(4).Add(TimeSpan.FromSeconds(17))
        });

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}/{existingSong.Id}");
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();
        result!.Id.Should().Be(existingSong.Id);
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnNotFoundStatusCode_When_NotFound()
    {
        var invalidSongId = Guid.NewGuid();
        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}/{invalidSongId}");

        await _infrastructure.ResetDataAsync();

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        response.Should().NotBeNull();
    }

    [Fact]
    public async Task UpdateSongAsync_Should_UpdateSong_When_ValidInput()
    {
        var songId = Guid.NewGuid();
        var updateRequest = new SongRequestModel()
        {
            Title = "Updated Title",
            Album = "Updated album",
            Author = "Conquer Divide",
            Duration = TimeSpan.FromMinutes(4).Add(TimeSpan.FromSeconds(17)),
        };

        var existingSong = await _infrastructure.SeedDataAsync(new Song()
        {
            Id = songId,
            Title = "Playing w fire",
            Album = "Slow Burn",
            Author = "Conquer Divide",
            Duration = TimeSpan.FromMinutes(4).Add(TimeSpan.FromSeconds(17))
        });

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.PutAsJsonAsync($"{TestConstants.SongsApiRoute}/{songId}", updateRequest);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();

        result?.Title.Should().Be(updateRequest.Title);
        result?.Id.Should().Be(existingSong.Id);
    }

    [Fact]
    public async Task DeleteSongAsync_Should_DeleteSong_When_ValidInput()
    {
        var songId = Guid.NewGuid();
        var existingSong = await _infrastructure.SeedDataAsync(new Song()
        {
            Id = songId,
            Title = "Take it to the edge",
            Album = "Godsmack",
            Author = "Godsmack",
            Duration = TimeSpan.FromMinutes(3).Add(TimeSpan.FromSeconds(49))
        });

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.SongsApiRoute}/{songId}");

        using var scopeAfterRemoval = _infrastructure.Factory.Services.CreateScope();
        var context = scopeAfterRemoval.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var oldSong = await context.Songs.FirstOrDefaultAsync(s => s.Id == songId);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        oldSong.Should().BeNull();
        response.Should().NotBeNull();
    }
}