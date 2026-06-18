using System.ComponentModel.DataAnnotations;

namespace Vladify.BusinessLogic.Options;

public class RabbitMqOptions
{
    public const string SectionName = "RabbitMqOptions";

    [Required]
    public required string ServerHost { get; set; }

    [Required]
    public required string Username { get; set; }

    [Required]
    public required string Password { get; set; }
}
