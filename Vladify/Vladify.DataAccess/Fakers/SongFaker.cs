using Bogus;
using Bogus.Extensions;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Fakers;

public class SongFaker : Faker<Song>
{
    public SongFaker()
    {
        RuleFor(r => r.Id, p => p.Random.Guid());
        RuleFor(r => r.Title, p =>
        {
            string phrase = p.Hacker.Phrase();
            string[] words = phrase.Split();
            string partOfPhrase = $"{words[0]} {words[1]} {words[2]}";
            return partOfPhrase;
        });
        RuleFor(r => r.Album, p => p.Commerce.ProductName().ClampLength(max: 50));
        RuleFor(r => r.Author, p => $"{p.Name.FirstName()} {p.Name.LastName()}".ClampLength(max: 50));
        RuleFor(r => r.Duration, p => TimeSpan.FromSeconds(p.Random.Int(150, 210)));
    }
}
