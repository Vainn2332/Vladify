namespace Vladify.BusinessLogic.Constants;

public static class BusinessLogicLayerConstants
{
    public const string BaseClaimNamespace = "https://vladify.com/";

    public const string CustomEmailClaimName = $"{BaseClaimNamespace}email";

    public const string User_NotFoundById_ErrorMessage = "User with such id not found!";

    public const string User_NotFoundByEmail_ErrorMessage = "User with such email not found!";

    public const string User_Forbidden_ErrorMessage = "You don't have permissions to modify this user!";


}
