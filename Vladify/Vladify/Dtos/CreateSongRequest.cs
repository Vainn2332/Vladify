using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;

namespace Vladify.Dtos;

/// <summary>
/// This class must be manually mapped to SongAddDto in the business logic layer(AutoMapper doesn't see it because dto is in API layer because of AspNet's IFormFile)
/// </summary>
public class CreateSongRequest
{
    public required string Title { get; set; }

    public required string Album { get; set; }

    public required IFormFile Audio { get; set; }

    public required IFormFile Cover { get; set; }

    public SongAddDto ToSongAddDto()
    {
        return new SongAddDto
        {
            Title = this.Title,
            Album = this.Album,
            Audio = new FileData
            {
                FileName = this.Audio.FileName,
                ContentType = this.Audio.ContentType,
                Content = this.Audio.OpenReadStream()
            },
            Cover = new FileData
            {
                FileName = this.Cover.FileName,
                ContentType = this.Cover.ContentType,
                Content = this.Cover.OpenReadStream()
            }
        };
    }
}
