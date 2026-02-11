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
        builder.Property(p => p.Title).HasMaxLength(DalConstants.MaxStandartStringLength);
        builder.Property(p => p.Album).HasMaxLength(DalConstants.MaxStandartStringLength);
        builder.Property(p => p.Author).HasMaxLength(DalConstants.MaxStandartStringLength);

        var fakeSongs = new SongFaker().Generate(DalConstants.SongSeedDataAmount);

        builder.HasData(fakeSongs);
    }
}
