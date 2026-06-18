using System.ComponentModel.DataAnnotations;

namespace Vladify.BusinessLogic.Options;

public class ClientCredentials
{
    [Required]
    public required string ClientId { get; set; }

    [Required]
    public required string ClientSecret { get; set; }

    [Required]
    public required string Audience { get; set; }
}
