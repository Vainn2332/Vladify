namespace Vladify.BusinessLogic.Models.PlaylistModels;

public class PlaylistRequestModel
{
    public Guid AuthorId { get; set; }

    public required string Name { get; set; }
}