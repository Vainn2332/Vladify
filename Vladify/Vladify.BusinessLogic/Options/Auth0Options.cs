namespace Vladify.BusinessLogic.Options;

public class Auth0Options
{
    public const string SectionName = "Auth0";

    public required string Domain { get; set; }

    public required string TokenUrl { get; set; }

    public required ClientCredentials PublicClient { get; set; }

    public required ClientCredentials M2MClient { get; set; }

}
