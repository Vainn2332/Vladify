using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class PlaylistRepository(ApplicationDbContext _context) : Repository<Playlist>(_context), IPlaylistRepository
{
    public async Task<Playlist> AddSongToPlaylistAsync(Playlist playlist, Song song, CancellationToken cancellationToken)
    {
        playlist.Songs.Add(song);

        await _context.SaveChangesAsync(cancellationToken);

        return playlist;
    }

    public Task<Playlist?> GetPlaylistAsync(Guid id, bool isTracking, CancellationToken cancellationToken)
    {
        return (isTracking ? _context.Playlists : _context.Playlists.AsNoTracking())
            .Include(p => p.Songs)
            .ThenInclude(p => p.Owner)
            .Include(p => p.Owner)
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Playlist>> GetPlaylistsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Playlists
            .Include(p => p.Songs)
            .ThenInclude(p => p.Owner)
            .Include(p => p.Owner)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Playlist>> GetPlaylistsOfUserAsync(Guid userId, int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Playlists
            .Where(s => s.AuthorId == userId)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public async Task<Playlist> DeleteSongFromPlaylistAsync(Playlist playlist, Song song, CancellationToken cancellationToken)
    {
        playlist.Songs.Remove(song);

        await _context.SaveChangesAsync(cancellationToken);

        return playlist;
    }
}