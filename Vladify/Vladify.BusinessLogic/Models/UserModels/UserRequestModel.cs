using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models.UserModels;

public class UserRequestModel
{
    public required string Name { get; set; }

    public required string EmailAddress { get; set; }

    public required string Password { get; set; }

    public required int Age { get; set; }

    public required Gender Gender { get; set; }
}
