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
    public async Task AddSongAsync_Should_SaveToDatabase()
    {
        var request = new SongRequestModel
        {
            Album = "ENMY",
            Title = "Clarity",
            Author = "ENMY",
            Duration = TimeSpan.FromMinutes(8)
        };
        var token = _infrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsJsonAsync(TestConstants.SongsApiRoute, request);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var songInDb = await dbContext.Songs
            .FirstOrDefaultAsync(s => s.Title == "Clarity");

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        Assert.NotNull(response);
        Assert.Equal(request.Album, result?.Album);
        Assert.NotEqual(Guid.Empty, result?.Id);

        Assert.NotNull(songInDb);
        Assert.NotEqual(Guid.Empty, songInDb.Id);
        Assert.Equal(request.Title, songInDb.Title);
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnSong()
    {
        var existingSong = new Song()
        {
            Id = Guid.NewGuid(),
            Title = "Playing w fire",
            Album = "Slow Burn",
            Author = "Conquer Divide",
            Duration = TimeSpan.FromMinutes(4).Add(TimeSpan.FromSeconds(17))
        };

        using (var scope = _infrastructure.Factory.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await dbContext.AddAsync(existingSong);
            await dbContext.SaveChangesAsync();
        }

        var jwt = _infrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}/{existingSong.Id}");
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        Assert.NotNull(response);
        Assert.Equal(existingSong.Id, result?.Id);
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnNotFoundException_When_NotFound()
    {
        var invalidSongId = Guid.NewGuid();
        var jwt = _infrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}/{invalidSongId}");

        await _infrastructure.ResetDataAsync();

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        Assert.NotNull(response);
    }

    [Fact]
    public async Task UpdateSongAsync_Should_UpdateSong()
    {
        var songId = Guid.NewGuid();
        var updateRequest = new SongRequestModel()
        {
            Title = "Updated Title",
            Album = "Updated album",
            Author = "Conquer Divide",
            Duration = TimeSpan.FromMinutes(4).Add(TimeSpan.FromSeconds(17)),
        };

        var existingSong = new Song()
        {
            Id = songId,
            Title = "Playing w fire",
            Album = "Slow Burn",
            Author = "Conquer Divide",
            Duration = TimeSpan.FromMinutes(4).Add(TimeSpan.FromSeconds(17))
        };
        using (var scope = _infrastructure.Factory.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await dbContext.AddAsync(existingSong);
            await dbContext.SaveChangesAsync();
        }

        var jwt = _infrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.PutAsJsonAsync($"{TestConstants.SongsApiRoute}/{songId}", updateRequest);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        Assert.NotNull(response);
        Assert.Equal(updateRequest.Title, result?.Title);
        Assert.Equal(existingSong.Id, result?.Id);
    }

    [Fact]
    public async Task DeleteSongAsync_Should_DeleteSong()
    {
        var songId = Guid.NewGuid();
        var existingSong = new Song()
        {
            Id = songId,
            Title = "Take it to the edge",
            Album = "Godsmack",
            Author = "Godsmack",
            Duration = TimeSpan.FromMinutes(3).Add(TimeSpan.FromSeconds(49))
        };
        using (var scope = _infrastructure.Factory.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await dbContext.AddAsync(existingSong);
            await dbContext.SaveChangesAsync();
        }

        var jwt = _infrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.SongsApiRoute}/{songId}");

        using var scopeAfterRemoval = _infrastructure.Factory.Services.CreateScope();
        var context = scopeAfterRemoval.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var oldSong = await context.Songs.FirstOrDefaultAsync(s => s.Id == songId);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        Assert.Null(oldSong);
        Assert.NotNull(response);
    }
}