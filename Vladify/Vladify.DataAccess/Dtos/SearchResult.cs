using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Dtos;

public record SearchResult
{
    public required IReadOnlyCollection<Song> Songs { get; set; }
    public required IReadOnlyCollection<User> Users { get; set; }
    public required IReadOnlyCollection<Playlist> Playlists { get; set; }
}
