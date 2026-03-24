namespace Vladify.BusinessLogic.Options;

public class Auth0Options
{
    private const string TokenEndpointPath = "oauth/token";
    private const string ManagementApiPath = "api/v2/";

    public const string SectionName = "Auth0";

    public required string Domain { get; set; }

    public required string Audience { get; set; }

    public required ClientCredentials PublicClient { get; set; }

    public required ClientCredentials M2MClient { get; set; }

    public string TokenUrl => $"https://{Domain}/{TokenEndpointPath}";

    public string ManagementApiAudience => $"https://{Domain}/{ManagementApiPath}";
}
