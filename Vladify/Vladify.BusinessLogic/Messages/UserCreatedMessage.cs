namespace Vladify.BusinessLogic.Messages;

public record UserCreatedMessage
{
    public required Guid UserId { get; init; }

    public required string EmailAddress { get; init; }
}
