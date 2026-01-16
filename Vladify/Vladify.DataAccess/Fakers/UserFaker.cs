using Bogus;
using Bogus.Extensions;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;

namespace Vladify.DataAccess.Fakers;

public class UserFaker : Faker<User>
{
    private const string StaticPasswordHash = "$2a$11$bTZDAvzREGMgTpStdByHWudfzZE3u4hRIdkTdyy4Hkjqsj.q/lcey";
    public UserFaker()
    {
        RuleFor(property => property.Id, setter => setter.Random.Guid());
        RuleFor(property => property.Name, setter => setter.Name.FirstName()
        .ClampLength(max: DALConstants.MaxStandartStringLength));
        RuleFor(property => property.EmailAddress, setter => setter.Internet.Email());
        RuleFor(property => property.PasswordHash, setter => StaticPasswordHash);
        RuleFor(property => property.Age, setter => setter.Random.Int(15, 100));
        RuleFor(property => property.Gender, setter => setter.PickRandomWithout(Gender.Undefined));
    }
}
