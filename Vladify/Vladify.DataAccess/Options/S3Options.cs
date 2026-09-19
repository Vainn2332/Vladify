using System.ComponentModel.DataAnnotations;

namespace Vladify.DataAccess.Options;

public class S3Options
{
    public const string SectionName = "S3Options";

    [Required]
    public required string ServiceUrl { get; set; }

    [Required]
    public required string AccessKey { get; set; }

    [Required]
    public required string SecretKey { get; set; }

    [Required]
    public required string BucketName { get; set; }
}
