using Amazon.S3;
using AutoFixture;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models.Pagination;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess;
using Vladify.DataAccess.Entities;
using Vladify.IntegrationTests.Constants;
using Vladify.IntegrationTests.Infrastructure;

namespace Vladify.IntegrationTests.Tests;

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
        var testUser = await _infrastructure.DataSeeder.SeedDataAsync(_fixture.Create<User>());

        var title = "Integration song";
        var album = "Integration album";

        var token = JwtBuilder.GenerateTestJWT(testUser.EmailAddress);
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        using var request = new MultipartFormDataContent()
        {
            { new StringContent(title),"Title"},
            { new StringContent(album),"Album"},
            { new StringContent("00:03:19"),"Duration"}
        };
        var audio = new ByteArrayContent(new byte[] { 1, 2, 3 });
        audio.Headers.ContentType = new MediaTypeHeaderValue("audio/mpeg");
        request.Add(audio, "Audio", "song.mp3");

        var cover = new ByteArrayContent(new byte[] { 4, 5, 6 });
        cover.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
        request.Add(cover, "Cover", "cover.jpg");

        using var response = await _infrastructure.Client.PostAsync(TestConstants.SongsApiRoute, request);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var songInDb = await dbContext.Songs
            .FirstAsync(s => s.Title == title);

        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();
        var isAudioPresentInS3 = await StorageInspector.CheckPresenceInBucket(s3, songInDb.AudioUrl, CancellationToken.None);
        var isCoverPresentInS3 = await StorageInspector.CheckPresenceInBucket(s3, songInDb.CoverUrl, CancellationToken.None);

        await _infrastructure.DataResetter.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();

        result!.Title.Should().Be(title);
        result!.Id.Should().NotBeEmpty();

        songInDb!.Id.Should().NotBeEmpty();
        songInDb.Title.Should().Be(title);
        songInDb.AuthorId.Should().Be(testUser.Id);

        isAudioPresentInS3.Should().BeTrue();
        isCoverPresentInS3.Should().BeTrue();
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnSong_When_ValidInput()
    {
        var user = _fixture.Create<User>();
        var song = _fixture.Create<Song>();
        song.AuthorId = user.Id;
        user.OwnedSongs = new List<Song>() { song };
        var testUser = await _infrastructure.DataSeeder.SeedDataAsync(user);

        var jwt = JwtBuilder.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}/{song.Id}");
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        await _infrastructure.DataResetter.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();
        result!.Id.Should().Be(song.Id);
    }

    [Fact]
    public async Task GetSongAsync_Should_ReturnNotFoundStatusCode_When_NotFound()
    {
        var invalidSongId = Guid.NewGuid();
        var jwt = JwtBuilder.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}/{invalidSongId}");

        await _infrastructure.DataResetter.ResetDataAsync();

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        response.Should().NotBeNull();
    }

    [Fact]
    public async Task GetAllSongs_Should_SetHasNextPageTrue_When_MoreItemsThanPage()
    {
        await _infrastructure.DataResetter.ResetDataAsync();

        var user = _fixture.Create<User>();
        var songs = _fixture.CreateMany<Song>(3).ToList();
        foreach (var song in songs)
            song.AuthorId = user.Id;
        user.OwnedSongs = songs;

        await _infrastructure.DataSeeder.SeedDataAsync(user);

        var jwt = JwtBuilder.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}?PageNumber=1&PageSize=2");

        await _infrastructure.DataResetter.ResetDataAsync();

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<PagedResponse<SongModel>>();
        result.Should().NotBeNull();
        result.Data.Should().HaveCount(2);
        result.HasNextPage.Should().BeTrue();
    }

    [Fact]
    public async Task GetAllSongs_Should_SetHasNextPageFalse_When_LastPageIsFull()
    {
        await _infrastructure.DataResetter.ResetDataAsync();

        var user = _fixture.Create<User>();
        var songs = _fixture.CreateMany<Song>(2).ToList();
        foreach (var song in songs)
            song.AuthorId = user.Id;
        user.OwnedSongs = songs;

        await _infrastructure.DataSeeder.SeedDataAsync(user);

        var jwt = JwtBuilder.GenerateTestJWT();
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.GetAsync($"{TestConstants.SongsApiRoute}?PageNumber=1&PageSize=2");

        await _infrastructure.DataResetter.ResetDataAsync();

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<PagedResponse<SongModel>>();
        result.Should().NotBeNull();
        result.Data.Should().HaveCount(2);
        result.HasNextPage.Should().BeFalse();
    }

    [Fact]
    public async Task UpdateSongAsync_Should_UpdateSong_When_ValidInput()
    {
        var user = _fixture.Create<User>();
        var song = _fixture.Create<Song>();
        song.AuthorId = user.Id;
        user.OwnedSongs = new List<Song>() { song };

        var testUser = await _infrastructure.DataSeeder.SeedDataAsync(user);

        var updateRequest = _fixture.Create<UpdateSongRequestModel>();

        var jwt = JwtBuilder.GenerateTestJWT(testUser.EmailAddress);
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.PutAsJsonAsync($"{TestConstants.SongsApiRoute}/{song.Id}", updateRequest);
        var result = await response.Content.ReadFromJsonAsync<SongModel>();

        await _infrastructure.DataResetter.ResetDataAsync();

        response.EnsureSuccessStatusCode();
        response.Should().NotBeNull();

        result?.Title.Should().Be(updateRequest.Title);
        result?.Id.Should().Be(song.Id);
    }

    [Fact]
    public async Task DeleteSongAsync_Should_DeleteSong_When_ValidInput()
    {
        var user = _fixture.Create<User>();
        var song = _fixture.Create<Song>();
        song.AuthorId = user.Id;
        user.OwnedSongs = new List<Song>() { song };

        var testUser = await _infrastructure.DataSeeder.SeedDataAsync(user);
        await _infrastructure.DataSeeder.SeedDataInBlobAsync(song.AudioUrl, CancellationToken.None);
        await _infrastructure.DataSeeder.SeedDataInBlobAsync(song.CoverUrl, CancellationToken.None);

        var jwt = JwtBuilder.GenerateTestJWT(testUser.EmailAddress);
        _infrastructure.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        using var response = await _infrastructure.Client.DeleteAsync($"{TestConstants.SongsApiRoute}/{song.Id}");

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var oldSong = await context.Songs.FirstOrDefaultAsync(s => s.Id == song.Id);

        var s3 = scope.ServiceProvider.GetRequiredService<IAmazonS3>();
        var isAudioPresentInBuket = await StorageInspector.CheckPresenceInBucket(s3, song.AudioUrl, CancellationToken.None);
        var isCoverPresentInBucket = await StorageInspector.CheckPresenceInBucket(s3, song.CoverUrl, CancellationToken.None);

        await _infrastructure.DataResetter.ResetDataAsync();

        isAudioPresentInBuket.Should().BeFalse();
        isCoverPresentInBucket.Should().BeFalse();

        response.EnsureSuccessStatusCode();
        oldSong.Should().BeNull();
        response.Should().NotBeNull();
    }
}
