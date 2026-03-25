namespace Vladify.BusinessLogic.Models.UserModels;

public class UserRequestModel
{
    public required string ExternalId { get; set; }

    public required string Name { get; set; }

    public required string EmailAddress { get; set; }
}
