namespace Vladify.BusinessLogic.Models.SongModels;

public class SongRequestModel
{
    public required string Title { get; set; }

    public required string Album { get; set; }

    public required string Author { get; set; }

    public Guid AuthorId { get; set; }// temporary field used for integration tests

    public required TimeSpan Duration { get; set; }
}
