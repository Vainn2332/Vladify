using Microsoft.AspNetCore.Http;

namespace Vladify.BusinessLogic.Models.SongModels;

public class SongAddDto
{
    public required string Title { get; set; }

    public required string Album { get; set; }

    public TimeSpan Duration { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public required IFormFile AudioFile { get; set; }

    public required IFormFile Image { get; set; }
}
