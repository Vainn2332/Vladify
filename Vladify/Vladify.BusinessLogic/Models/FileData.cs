namespace Vladify.BusinessLogic.Models;

public class FileData
{
    public required Stream Content { get; set; }

    public required string ContentType { get; set; }

    public required string FileName { get; set; }
}
