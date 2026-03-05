using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models.UserModels;

public class UserModel
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string EmailAddress { get; set; }

    public required int Age { get; set; }

    public Gender Gender { get; set; } = Gender.Undefined;
}
