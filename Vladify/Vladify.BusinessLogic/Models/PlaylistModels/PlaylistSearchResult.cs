namespace Vladify.BusinessLogic.Models.PlaylistModels;

public class PlaylistSearchResult
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string AuthorName { get; set; }
}
