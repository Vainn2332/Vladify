using Vladify.BusinessLogic.Models.SongModels;

namespace Vladify.BusinessLogic.Models.PlaylistModels;

public class PlaylistModel
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string AuthorName { get; set; }

    public required IEnumerable<SongModel> Songs { get; set; }
}
