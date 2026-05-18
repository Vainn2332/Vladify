namespace Vladify.BusinessLogic.Options;

public class RabbitMqOptions
{
    public const string SectionName = "RabbitMqOptions";

    public required string ServerHost { get; set; }

    public required string Username { get; set; }

    public required string Password { get; set; }
}
