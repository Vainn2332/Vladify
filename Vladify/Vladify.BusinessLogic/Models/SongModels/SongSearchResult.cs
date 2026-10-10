namespace Vladify.BusinessLogic.Models.SongModels;

public class SongSearchResult
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public required string Author { get; set; }

    public required string AudioUrl { get; set; }

    public required string CoverUrl { get; set; }
}
