using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Entities;

public class User : IEntity
{
    public required Guid Id { get; set; }

    public required string ExternalId { get; set; }

    public required string EmailAddress { get; set; }

    public required string Name { get; set; }

    public int Age { get; set; }

    public Gender Gender { get; set; } = Gender.Undefined;
}
