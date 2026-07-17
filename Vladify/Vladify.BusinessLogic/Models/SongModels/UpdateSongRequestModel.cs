namespace Vladify.BusinessLogic.Models.SongModels;

public class UpdateSongRequestModel
{
    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;

    public string Author { get; set; } = null!;

    public Guid AuthorId { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
}
