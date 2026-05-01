using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class PlaylistRepository(ApplicationDbContext _context) : Repository<Playlist>(_context), IPlaylistRepopsitory
{
    public Task<Playlist?> GetPlaylistAsync(Guid id, bool isTracking, CancellationToken cancellationToken)
    {
        return (isTracking ? _context.Playlists : _context.Playlists.AsNoTracking())
            .Include(p => p.Songs)
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Playlist>> GetPlaylistsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Playlists
            .Include(p => p.Songs)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }
}
