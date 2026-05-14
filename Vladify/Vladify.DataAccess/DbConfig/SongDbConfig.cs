using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.DbConfig;

public class SongDbConfig : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Title).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);
        builder.Property(p => p.Album).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);
    }
}
