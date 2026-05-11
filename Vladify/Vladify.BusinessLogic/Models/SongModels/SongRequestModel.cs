using Microsoft.AspNetCore.Http;

namespace Vladify.BusinessLogic.Models.SongModels;

public class SongRequestModel
{
    public Guid AuthorId { get; set; }

    public required string Title { get; set; }

    public required string Album { get; set; }

    public TimeSpan Duration { get; set; }

    public required IFormFile AudioFile { get; set; }

    public required IFormFile Image { get; set; }
}
