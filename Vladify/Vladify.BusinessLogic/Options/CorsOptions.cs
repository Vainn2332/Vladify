namespace Vladify.BusinessLogic.Options;

public class CorsOptions
{
    public const string SectionName = "Cors";

    public required string[] AllowedOrigins { get; set; }
}
