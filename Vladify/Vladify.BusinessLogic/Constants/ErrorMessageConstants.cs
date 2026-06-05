namespace Vladify.BusinessLogic.Constants;

public static class ErrorMessageConstants
{
    public const string UserNotFoundById = "User with such id not found!";

    public const string UserNotFoundByEmail = "User with such email not found!";

    public const string UserForbidden = "You don't have permissions to modify this user!";

    public const string UnableToGetUserEmail = "Unable to get user externalId!";

    public const string PlaylistNotFoundById = "Playlist with such id not found!";

    public const string PlaylistForbidden = "You don't have permissions to modify this playlist!";

    public const string SongNotFoundById = "Song with such id not found!";
}
