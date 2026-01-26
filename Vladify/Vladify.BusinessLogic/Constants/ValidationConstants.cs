namespace Vladify.BusinessLogic.Constants;

public static class ValidationConstants
{
    public const int MaxDefaultStringLength = 50;

    public static readonly TimeSpan MinSongDuration = TimeSpan.FromSeconds(10);

    public static readonly TimeSpan MaxSongDuration = TimeSpan.FromMinutes(30);
}
