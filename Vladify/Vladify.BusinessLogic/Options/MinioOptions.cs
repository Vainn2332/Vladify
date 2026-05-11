namespace Vladify.BusinessLogic.Options;

public class MinioOptions
{
    public const string SectionName = "MiniO";

    public required string ServiceUrl { get; set; }

    public required string AccessKey { get; set; }

    public required string SecretKey { get; set; }

    public required string BucketName { get; set; }
}
