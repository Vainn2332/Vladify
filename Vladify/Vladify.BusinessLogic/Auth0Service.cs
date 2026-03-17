using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Options;

namespace Vladify.BusinessLogic;

public class Auth0Service(IOptions<Auth0Options> _options) : IAuth0Service
{
    private readonly Auth0Options _authOptions = _options.Value;
    public async Task DeleteUserFromAuth0Async(string authId)
    {
        var token = await GetManagementTokenAsync();

        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var encodedId = Uri.EscapeDataString(authId);

        using var response = await httpClient.DeleteAsync($"https://{_authOptions.Domain}/api/v2/users/{encodedId}");
        response.EnsureSuccessStatusCode();
    }

    private async Task<string> GetManagementTokenAsync()
    {
        var httpClient = new HttpClient();

        using var response = await httpClient.PostAsJsonAsync($"https://{_options.Value.Domain}/oauth/token", new
        {
            client_id = _authOptions.ClientId,
            client_secret = _authOptions.ClientSecret,
            audience = $"https://{_authOptions.Domain}/api/v2/",
            grant_type = "client_credentials"
        });
        response.EnsureSuccessStatusCode();

        var token = await response.Content.ReadFromJsonAsync<Auth0TokenResponse>();
        return token!.AccessToken;
    }
}
