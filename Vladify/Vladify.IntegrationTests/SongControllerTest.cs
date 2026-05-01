using AutoFixture;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess;
using Vladify.DataAccess.Entities;
namespace Vladify.IntegrationTests;

[Collection("FixtureCollection")]
public class SongControllerTest
{
    private readonly IntegrationTestInfrastructure _infrastructure;
    private readonly IFixture _fixture;

    public SongControllerTest(IntegrationTestInfrastructure infrastructure)
    {
        _infrastructure = infrastructure;
        _fixture = AutoFixtureOptions.CreateFixture();
    }

    [Fact]
    public async Task AddSongAsync_Should_SaveToDatabase_When_ValidInput()
    {
        var testUser = _fixture.Create<User>();
        var existingUser = await _infrastructure.SeedDataAsync(testUser);
        var request = _fixture.Create<SongRequestModel>();
        request.AuthorId = existingUser.Id;
        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsJsonAsync(TestConstants.SongsApiRoute, request);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var songInDb = await dbContext.Songs
            .FirstOrDefaultAsync(s => s.Title == request.Title);

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
    public async Task AddSongAsync_ShouldThrowError_When_OrphanRecordInput()
    {
        var request = _fixture.Create<SongRequestModel>();
        var token = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var response = await _infrastructure.Client.PostAsJsonAsync(TestConstants.SongsApiRoute, request);
        var error = await response.Content.ReadFromJsonAsync<ErrorDetails>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var songInDb = await dbContext.Songs
            .FirstOrDefaultAsync(s => s.Title == request.Title);

        await _infrastructure.ResetDataAsync();

        response.Should().NotBeNull();
        error?.StatusCode.Should().Be((int)HttpStatusCode.InternalServerError);
        songInDb.Should().BeNull();
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnSong_When_ValidInput()
    {
        var testUser = _fixture.Create<User>();
        var existingUser = await _infrastructure.SeedDataAsync(testUser);
        var song = _fixture.Create<Song>();
        song.AuthorId = existingUser.Id;
        var existingSong = await _infrastructure.SeedDataAsync(song);

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
        var testUser = _fixture.Create<User>();
        var existingUser = await _infrastructure.SeedDataAsync(testUser);
        var testSong = _fixture.Create<Song>();
        testSong.AuthorId = existingUser.Id;
        var existingSong = await _infrastructure.SeedDataAsync(testSong);

        var updateRequest = _fixture.Create<SongRequestModel>();
        updateRequest.AuthorId = existingUser.Id;
        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.PutAsJsonAsync($"{TestConstants.SongsApiRoute}/{existingSong.Id}", updateRequest);
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
        var testUser = _fixture.Create<User>();
        var existingUser = await _infrastructure.SeedDataAsync(testUser);
        var testSong = _fixture.Create<Song>();
        testSong.AuthorId = existingUser.Id;
        var existingSong = await _infrastructure.SeedDataAsync(testSong);

        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.SongsApiRoute}/{existingSong.Id}");

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var oldSong = await context.Songs.FirstOrDefaultAsync(s => s.Id == existingSong.Id);

        await _infrastructure.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        oldSong.Should().BeNull();
        response.Should().NotBeNull();
    }
}
