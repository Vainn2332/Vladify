using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess;

public class SongDbConfig : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Title).HasMaxLength(50);
        builder.Property(p => p.Album).HasMaxLength(50);
        builder.Property(p => p.Author).HasMaxLength(50);
    }
}
