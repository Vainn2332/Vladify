using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess;

public class UserDbConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.EmailAddress).IsUnique();
        builder.Property(p => p.Gender).HasConversion<string>();//сохраняем Male вместо 1 в БД
        builder.Property(p => p.Name).HasMaxLength(DALConstants.MaxStandartStringLength);
    }
}
