namespace Vladify.DataAccess.Entities;

public class Song
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Album { get; set; } = null!;

    public string Author { get; set; } = null!;

    public TimeSpan Duration { get; set; } = TimeSpan.Zero;
}