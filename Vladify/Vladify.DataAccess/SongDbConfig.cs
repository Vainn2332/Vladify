using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess;

public class SongDbConfig : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Title).HasMaxLength(DALConstants.MaxStandartStringLength);
        builder.Property(p => p.Album).HasMaxLength(DALConstants.MaxStandartStringLength);
        builder.Property(p => p.Author).HasMaxLength(DALConstants.MaxStandartStringLength);
    }
}
