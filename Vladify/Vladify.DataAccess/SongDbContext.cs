using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess;

public class SongDbContext(DbContextOptions<SongDbContext> options) : DbContext(options)
{
    public DbSet<Song>? Songs { get; set; }
}
