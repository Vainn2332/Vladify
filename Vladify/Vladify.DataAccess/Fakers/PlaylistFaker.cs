using Bogus;
using Bogus.Extensions;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Fakers;

public sealed class PlaylistFaker : Faker<Playlist>
{
    public PlaylistFaker(IEnumerable<Guid> userIds)
    {
        RuleFor(property => property.Id, setter => setter.Random.Guid());

        RuleFor(property => property.Name, setter => $"{setter.Hacker.Adjective()} {setter.Music.Genre()}"
            .ClampLength(max: DataAccessLayerConstants.MaxStandartStringLength));

        RuleFor(property => property.AuthorId, setter => setter.PickRandom(userIds));
    }
}
