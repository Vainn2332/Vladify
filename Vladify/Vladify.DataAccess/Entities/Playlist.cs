using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Entities;

public class Playlist : IBaseEntity
{
    public Guid Id { get; set; }

    public Guid AuthorId { get; set; }

    public required string Name { get; set; }

    public required User Owner { get; set; }

    public required ICollection<Song> Songs { get; set; } = [];
}
