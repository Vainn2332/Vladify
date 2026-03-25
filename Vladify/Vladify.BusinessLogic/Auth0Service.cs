using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Options;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.BusinessLogic;

public class Auth0Service(IOptions<Auth0Options> _options, IHttpClientFactory _httpFactory) : IAuth0Service
{
    private readonly Auth0Options _authOptions = _options.Value;
    private readonly HttpClient _httpClient = _httpFactory.CreateClient();

    public async Task DeleteUserFromAuth0Async(string authId)
    {
        var token = await GetManagementTokenAsync();

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var encodedId = Uri.EscapeDataString(authId);

        using var response = await _httpClient.DeleteAsync($"{_authOptions.M2MClient.Audience}users/{encodedId}");

        response.EnsureSuccessStatusCode();
    }

    private async Task<string> GetManagementTokenAsync()
    {
        using var response = await _httpClient.PostAsJsonAsync(_authOptions.TokenUrl, new
        {
            client_id = _authOptions.M2MClient.ClientId,
            client_secret = _authOptions.M2MClient.ClientSecret,
            audience = _authOptions.M2MClient.Audience,
            grant_type = "client_credentials"
        });

        response.EnsureSuccessStatusCode();

        var token = await response.Content.ReadFromJsonAsync<Auth0TokenResponse>()
            ?? throw new ExternalServiceException("Failed to retrieve management token from Auth0!");

        return token.AccessToken;
    }
}
