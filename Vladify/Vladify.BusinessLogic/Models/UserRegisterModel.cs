using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models;

public class UserRegisterModel
{
    public string Name { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public int Age { get; set; } = 0;

    public Gender Gender { get; set; } = Gender.Undefined;
}
