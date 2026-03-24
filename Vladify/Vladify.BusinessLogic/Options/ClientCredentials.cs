namespace Vladify.BusinessLogic.Options;

public class ClientCredentials
{
    public required string ClientId { get; set; }

    public required string ClientSecret { get; set; }

    public required string Audience { get; set; }
}
