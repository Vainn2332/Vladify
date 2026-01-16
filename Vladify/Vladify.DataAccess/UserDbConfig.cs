using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Fakers;

namespace Vladify.DataAccess;

public class UserDbConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.EmailAddress).IsUnique();
        builder.Property(p => p.Gender).HasConversion<string>();//saving Male instead of 1 in Db
        builder.Property(p => p.Name).HasMaxLength(DALConstants.MaxStandartStringLength);

        var fakeUsers = new UserFaker().Generate(DALConstants.UserSeedDataAmount);

        builder.HasData(fakeUsers);
    }
}
