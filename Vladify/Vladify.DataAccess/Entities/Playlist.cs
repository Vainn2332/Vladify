using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Entities;

public class Playlist : IEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public required string Name { get; set; }

    public required User User { get; set; }

    public required ICollection<Song> Songs { get; set; }

}
