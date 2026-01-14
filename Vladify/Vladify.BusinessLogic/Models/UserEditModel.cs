using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models;

public class UserEditModel
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; } = 0;

    public Gender Gender { get; set; } = Gender.Undefined;
}
