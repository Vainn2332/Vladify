using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Entities;

public class Song : IBaseEntity
{
    public required Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;

    public Guid? AuthorId { get; set; }

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;

    public required User Owner { get; set; }

    public required ICollection<Playlist> Playlists { get; set; } = [];
}
