using Vladify.DataAccess.Enums;

namespace Vladify.DataAccess.Entities;

public class User : BaseEntity
{
    public string Name { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public required int Age { get; set; }

    public Gender Gender { get; set; } = Gender.Undefined;
}
