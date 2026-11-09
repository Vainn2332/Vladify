using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models.SongModels;

public class SongModel
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;

    public string Author { get; set; } = null!;

    public SongStatus Status { get; set; }

    public required string AudioUrl { get; set; }

    public required string CoverUrl { get; set; }

    public bool IsAuthor { get; set; } = false;

    public Guid AuthorId { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
}
