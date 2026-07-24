namespace Vladify.BusinessLogic.Models.SongModels;

public class SongUpdateDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;
}
