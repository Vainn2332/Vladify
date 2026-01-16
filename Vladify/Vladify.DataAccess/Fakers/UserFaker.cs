using Bogus;
using Bogus.Extensions;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;

namespace Vladify.DataAccess.Fakers;

public class UserFaker : Faker<User>
{
    private static readonly string StaticPasswordHash =
    BCrypt.Net.BCrypt.EnhancedHashPassword("TestPassword123");
    public UserFaker()
    {
        RuleFor(r => r.Id, p => p.Random.Guid());
        RuleFor(r => r.Name, p => p.Name.FirstName().ClampLength(max: 50));
        RuleFor(r => r.EmailAddress, p => p.Internet.Email());
        RuleFor(r => r.PasswordHash, p => StaticPasswordHash);
        RuleFor(r => r.Age, p => p.Random.Int(15, 100));
        RuleFor(r => r.Gender, p => p.PickRandomWithout(Gender.Undefined));
    }
}
