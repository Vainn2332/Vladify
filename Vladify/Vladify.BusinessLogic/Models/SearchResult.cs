using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Models.UserModels;

namespace Vladify.BusinessLogic.Models;

public record SearchResult
{
    public required IReadOnlyCollection<SongSearchResult> Songs { get; init; }
    public required IReadOnlyCollection<UserSearchResult> Users { get; init; }
    public required IReadOnlyCollection<PlaylistSearchResult> Playlists { get; init; }
}
