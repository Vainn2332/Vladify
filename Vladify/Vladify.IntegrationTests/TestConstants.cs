namespace Vladify.IntegrationTests;

public static class TestConstants
{
    public const string SongsApiRoute = "/api/songs";

    public const string UsersApiRoute = "/api/users";

    public const string TestSecretKey = "superSecretTestKeyThatIsIntendedOnlyForTestPurposes!";

    public const string Issuer = "testIssuer";

    public const string Audience = "testAudience";

    public const int TestDataStringValuesLength = 25;

    public const int TestDataTimeSpanValuesMaxDurationInMinutes = 30;

    public const int TestDataTimeSpanValuesMinDurationInSeconds = 10;

    public const string TestJwtEmailClaimValue = "testtt@mail.ru";
}
