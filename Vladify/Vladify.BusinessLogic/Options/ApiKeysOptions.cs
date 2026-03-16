namespace Vladify.Options;

public class ApiKeysOptions
{
    public const string SectionName = "ApiKeys";

    public string Auth0SyncInDb { get; set; } = string.Empty;
}
