namespace Vladify.BusinessLogic.Models.SongModels;

public class SongModel
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;

    public string Author { get; set; } = null!;

    public Guid AuthorId { get; set; }// temporary field used for integration tests

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
}
