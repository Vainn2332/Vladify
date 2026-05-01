namespace Vladify.BusinessLogic.Models.SongModels;

public class SongUpdateRequestModel
{
    public required string Title { get; set; }

    public required string Album { get; set; }

    public Guid AuthorId { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
}
