using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models.UserModels;

public class UserUpdateDto
{
    public required string Name { get; set; }

    public required int Age { get; set; }

    public required Gender Gender { get; set; }
}
