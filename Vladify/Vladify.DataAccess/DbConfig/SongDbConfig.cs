using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Fakers;

namespace Vladify.DataAccess.DbConfig;

public class SongDbConfig : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Title).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);
        builder.Property(p => p.Album).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);
        builder.Property(p => p.Author).HasMaxLength(DataAccessLayerConstants.MaxStandartStringLength);

        var fakeSongs = new SongFaker().Generate(DataAccessLayerConstants.SongSeedDataAmount);

        builder.HasData(fakeSongs);
    }
}
