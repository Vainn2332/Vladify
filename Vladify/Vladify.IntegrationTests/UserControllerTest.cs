using AutoFixture;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.DataAccess;
using Vladify.DataAccess.Entities;
using Vladify.Options;

namespace Vladify.IntegrationTests;

[Collection("FixtureCollection")]
public class UserControllerTest
{
    private readonly IntegrationTestInfrastructure _infrastructure;
    private readonly IFixture _fixture;

    public UserControllerTest(IntegrationTestInfrastructure infrastructure)
    {
        _infrastructure = infrastructure;
        _fixture = AutoFixtureOptions.CreateFixture();
    }

    [Fact]
    public async Task AddUserAsync_Should_SaveToDatabase_When_ValidInput()
    {
        var requestBody = _fixture.Create<UserRequestModel>();
        using var scope = _infrastructure.Factory.Services.CreateScope();
        var options = scope.ServiceProvider.GetRequiredService<IOptions<ApiKeysOptions>>();
        var apiKey = options.Value.Auth0SyncInDb;
        var request = new HttpRequestMessage(HttpMethod.Post, TestConstants.UsersApiRoute);
        request.Headers.Add("X-Api-Key", apiKey);
        request.Content = JsonContent.Create(requestBody);

        using var response = await _infrastructure.Client.SendAsync(request);
        var result = await response.Content.ReadFromJsonAsync<UserModel>();

        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var user = await context.Users.FirstOrDefaultAsync(u => u.ExternalId == requestBody.ExternalId);

        result.Should().NotBeNull();
        user.Should().NotBeNull();
        user.ExternalId.Should().Be(requestBody.ExternalId);

        await _infrastructure.ResetDataAsync();
    }

    [Fact]
    public async Task AddUserAsync_Should_ThrowUnauthorizedException_When_InvalidApiKey()
    {
        var requestBody = _fixture.Create<UserRequestModel>();
        var request = new HttpRequestMessage(HttpMethod.Post, TestConstants.UsersApiRoute);
        request.Headers.Add("X-Api-Key", "wrongApiKey");
        request.Content = JsonContent.Create(requestBody);

        using var response = await _infrastructure.Client.SendAsync(request);

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var user = await context.Users.FirstOrDefaultAsync(u => u.ExternalId == requestBody.ExternalId);


        user.Should().BeNull();
        response.Should().NotBeNull();
        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);

        await _infrastructure.ResetDataAsync();
    }

    [Fact]
    public async Task DeleteUser_Should_DeleteFromDb_When_ValidInput()
    {
        var existingUser = _fixture.Create<User>();
        await _infrastructure.SeedDataAsync(existingUser);
        var request = new HttpRequestMessage(HttpMethod.Delete, $"{TestConstants.UsersApiRoute}/{existingUser.Id}");
        var jwt = IntegrationTestInfrastructure.GenerateTestJWT();
        request.Headers.Add("Authorization", $"Bearer {jwt}");

        using var response = await _infrastructure.Client.SendAsync(request);

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var user = await context.Users.FirstOrDefaultAsync(u => u.Id == existingUser.Id);


        user.Should().BeNull();
        response.Should().NotBeNull();

        await _infrastructure.ResetDataAsync();
    }

    [Fact]
    public async Task DeleteUser_Should_ThrowUnauthorizedException_When_NotAuthorized()
    {
        var existingUser = _fixture.Create<User>();
        await _infrastructure.SeedDataAsync(existingUser);
        var request = new HttpRequestMessage(HttpMethod.Delete, $"{TestConstants.UsersApiRoute}/{existingUser.Id}");

        var client = _infrastructure.Factory.CreateClient();
        using var response = await client.SendAsync(request);

        using var scope = _infrastructure.Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var user = await context.Users.FirstOrDefaultAsync(u => u.Id == existingUser.Id);


        user.Should().NotBeNull();
        response.Should().NotBeNull();
        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);

        await _infrastructure.ResetDataAsync();
    }
}
