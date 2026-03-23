using AutoFixture;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.Options;

namespace Vladify.IntegrationTests;

public class UserControllerTest//////////////////////////////реализовать CollecionFixture!!!!!!!!!!!
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

        var response = await _infrastructure.Client.SendAsync(request);


    }
}
