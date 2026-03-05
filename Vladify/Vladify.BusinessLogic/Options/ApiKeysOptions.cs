namespace Vladify.Options;

public class ApiKeysOptions
{
    public const string SectionName = "ApiKeys";

    public required string Auth0SyncInDb { get; set; }
}
