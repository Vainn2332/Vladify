namespace Vladify.BusinessLogic.Messages;

public class UserCreatedMessage
{
    public Guid UserId { get; set; }

    public required string EmailAddress { get; set; }
}
