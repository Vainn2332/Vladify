using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Dtos;

public record SearchResult
{
    public required IReadOnlyCollection<Song> Songs { get; init; }
    public required IReadOnlyCollection<User> Users { get; init; }
    public required IReadOnlyCollection<Playlist> Playlists { get; init; }
}
