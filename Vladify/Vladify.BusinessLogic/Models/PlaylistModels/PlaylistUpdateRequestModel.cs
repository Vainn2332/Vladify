namespace Vladify.BusinessLogic.Models.PlaylistModels;

public class PlaylistUpdateRequestModel
{
    public Guid Id { get; set; }

    public required string Name { get; set; }
}
