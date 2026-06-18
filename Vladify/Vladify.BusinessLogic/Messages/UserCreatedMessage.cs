namespace Vladify.BusinessLogic.Messages;

public record UserCreatedMessage(Guid UserId, string EmailAddress) { }
