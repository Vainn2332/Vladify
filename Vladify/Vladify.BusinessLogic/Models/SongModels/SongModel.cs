namespace Vladify.BusinessLogic.Models.SongModels;

public class SongModel
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public required string Album { get; set; }

    public required string Author { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;

    public required string AudioUrl { get; set; }

    public required string ImageUrl { get; set; }
}
