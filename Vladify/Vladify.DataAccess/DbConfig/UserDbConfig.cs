using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Fakers;

namespace Vladify.DataAccess.DbConfig;

public class UserDbConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.EmailAddress).IsUnique();
        builder.HasIndex(p => p.ExternalId).IsUnique();
        builder.Property(p => p.Gender).HasConversion<string>();//saving Male instead of 1 in Db
        builder.Property(p => p.Name).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);

        var fakeUsers = new UserFaker().Generate(DataAccessLayerConstants.UserSeedDataAmount);

        builder.HasData(fakeUsers);

        builder.HasMany(p => p.OwnedSongs)
           .WithOne(p => p.Owner)
           .HasForeignKey(k => k.AuthorId)
           .OnDelete(DeleteBehavior.SetNull);
    }
}
