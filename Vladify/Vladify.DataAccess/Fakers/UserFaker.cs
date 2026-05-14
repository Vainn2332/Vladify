using Bogus;
using Bogus.Extensions;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;

namespace Vladify.DataAccess.Fakers;

public sealed class UserFaker : Faker<User>
{
    public UserFaker()
    {
        RuleFor(property => property.Id, setter => setter.Random.Guid());

        RuleFor(p => p.ExternalId, setter => $"auth0|{setter.Random.Hash(24)}");

        RuleFor(property => property.Name, setter => setter.Name.FirstName()
            .ClampLength(max: DataAccessLayerConstants.MaxStandartStringLength));

        RuleFor(property => property.EmailAddress, setter => setter.Internet.Email());

        RuleFor(property => property.Age, setter => setter.Random.Int(15, 100));

        RuleFor(property => property.Gender, setter => setter.PickRandomWithout(Gender.Undefined));
    }
}
