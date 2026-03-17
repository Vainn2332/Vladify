using System.Text.Json.Serialization;

namespace Vladify.BusinessLogic.Models;

public class Auth0TokenResponse
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; set; }
}
