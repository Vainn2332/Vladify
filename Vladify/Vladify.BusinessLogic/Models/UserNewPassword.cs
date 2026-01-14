namespace Vladify.BusinessLogic.Models;

public class UserNewPassword
{
    public string EmailAddress { get; set; } = string.Empty;

    public string OldPassword{ get; set; } = string.Empty;

    public string NewPassword{ get; set; } = string.Empty;
}
