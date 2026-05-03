namespace Vladify.BusinessLogic.Models.SongModels;

public class SongRequestModel
{
    public Guid AuthorId { get; set; }

    public required string Title { get; set; }

    public required string Album { get; set; }

    public TimeSpan Duration { get; set; }
}
