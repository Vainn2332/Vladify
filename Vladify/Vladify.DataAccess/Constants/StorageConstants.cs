namespace Vladify.DataAccess.Constants;

public static class StorageConstants
{
    public static readonly TimeSpan PresignedUrlExpiration = TimeSpan.FromHours(1);

    public const string PresignClientKey = "presign";
}
