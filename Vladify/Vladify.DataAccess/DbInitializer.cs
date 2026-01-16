using Bogus;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Fakers;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

internal class DbInitializer(ApplicationDbContext context) : IDbInitializer
{
    public void Initialize()
    {
        Randomizer.Seed = new Random(DALConstants.RandomSeedDataNumber);

        if (!context.Users.Any())
        {
            var fakeUsers = new UserFaker().Generate(DALConstants.AmountOfUserSeedInstances);
            context.Users.AddRange(fakeUsers);
            context.SaveChanges();
        }

        if (!context.Songs.Any())
        {
            var fakeSongs = new SongFaker().Generate(DALConstants.AmountOfSongSeedInstances);
            context.Songs.AddRange(fakeSongs);
            context.SaveChanges();
        }
    }
}
