using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Entities;

public class Song : IEntity
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;

    public Guid? AuthorId { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;

    public DateTime CreatedAt { get; set; }

    public required string AudioUrl { get; set; }

    public required string ImageUrl { get; set; }

    public required User Owner { get; set; }

    public required ICollection<Playlist> Playlists { get; set; } = [];
}
