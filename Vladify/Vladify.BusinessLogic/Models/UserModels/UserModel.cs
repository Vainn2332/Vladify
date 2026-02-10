using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models.UserModels;

public class UserModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public required int Age { get; set; }

    public Gender Gender { get; set; } = Gender.Undefined;
}
