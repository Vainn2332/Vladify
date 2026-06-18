using System.ComponentModel.DataAnnotations;

namespace Vladify.BusinessLogic.Options;

public class Auth0Options
{
    public const string SectionName = "Auth0";

    [Required]
    public required string Domain { get; set; }

    [Required]
    public required string TokenUrl { get; set; }

    [Required]
    public required ClientCredentials PublicClient { get; set; }

    [Required]
    public required ClientCredentials M2MClient { get; set; }
}
