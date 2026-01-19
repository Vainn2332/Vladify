using Bogus;
using Bogus.Extensions;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Fakers;

public class SongFaker : Faker<Song>
{
    public SongFaker()
    {
        RuleFor(property => property.Id, setter => setter.Random.Guid());

        RuleFor(property => property.Title, setter =>
        {
            string phrase = setter.Hacker.Phrase();
            string[] words = phrase.Split();
            string partOfPhrase = $"{words[0]} {words[1]} {words[2]}";

            return partOfPhrase;
        });

        RuleFor(property => property.Album, setter => setter.Commerce.ProductName()
        .ClampLength(max: DALConstants.MaxStandartStringLength));

        RuleFor(property => property.Author, setter => $"{setter.Name.FirstName()} {setter.Name.LastName()}"
        .ClampLength(max: DALConstants.MaxStandartStringLength));

        RuleFor(property => property.Duration, setter => TimeSpan.FromSeconds(setter.Random.Int(150, 210)));
    }
}
