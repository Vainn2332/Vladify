namespace Vladify.BusinessLogic.Messages;

public record SongCreatedMessage
{
    public required string Title { get; init; }

    public required string Album { get; init; }

    public required string Author { get; init; }
}
