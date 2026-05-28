using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.DbConfig;

public class PlaylistDbConfig : IEntityTypeConfiguration<Playlist>
{
    public void Configure(EntityTypeBuilder<Playlist> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);

        builder.HasMany(p => p.Songs)
            .WithMany(p => p.Playlists);
    }
}