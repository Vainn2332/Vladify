using System.ComponentModel.DataAnnotations;

namespace Vladify.BusinessLogic.Options;

public class NetworkDelayOptions
{
    public const string SectionName = "NetworkDelay";

    public bool Enabled { get; set; }

    [Range(0, 60_000)]
    public int MinDelayMs { get; set; }

    [Range(0, 60_000)]
    public int MaxDelayMs { get; set; }
}
