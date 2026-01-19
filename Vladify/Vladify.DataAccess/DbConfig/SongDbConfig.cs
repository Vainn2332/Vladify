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
        builder.Property(p => p.Title).HasMaxLength(DALConstants.MaxStandartStringLength);
        builder.Property(p => p.Album).HasMaxLength(DALConstants.MaxStandartStringLength);
        builder.Property(p => p.Author).HasMaxLength(DALConstants.MaxStandartStringLength);

        var fakeSongs = new SongFaker().Generate(DALConstants.SongSeedDataAmount);

        builder.HasData(fakeSongs);
    }
}
