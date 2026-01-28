using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Entities;

public class User : IEntity
{
    public required Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public required int Age { get; set; }

    public Gender Gender { get; set; } = Gender.Undefined;
}
