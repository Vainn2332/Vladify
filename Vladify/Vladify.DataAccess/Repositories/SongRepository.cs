using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class SongRepository(ApplicationDbContext context) : Repository<Song>(context), ISongRepository
{
    public Task<Song?> GetSongWithUserInfoByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken)
    {
        return (isTracking ? _context.Songs : _context.Songs.AsNoTracking())
            .Include(p => p.Owner)
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Song>> GetSongsWithUserInfoByIdAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Songs
            .Include(p => p.Owner)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }
}
