namespace Vladify.BusinessLogic.Models.SongModels;

public class SongAddDto
{
    public required string Title { get; set; }

    public required string Album { get; set; }

    public string Author { get; set; } = null!;

    public required TimeSpan Duration { get; set; }

    public Guid AuthorId { get; set; }

    public required FileData Audio { get; set; }

    public required FileData Cover { get; set; }
}
