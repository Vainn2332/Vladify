namespace Vladify.Options;

public class Auth0Options
{
    public const string SectionName = "Auth0";

    public required string Domain { get; set; }
    public required string ClientId { get; set; }
    public required string Audience { get; set; }
}
