using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Dtos.Pagination;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class PlaylistRepository(ApplicationDbContext _context) : Repository<Playlist>(_context), IPlaylistRepository
{
    public async Task<Playlist> AddPlaylistAsync(Playlist playlist, CancellationToken cancellationToken)
    {
        await _context.Playlists.AddAsync(playlist, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        await _context.Entry(playlist)
            .Reference(p => p.Owner)
            .LoadAsync(cancellationToken);

        return playlist;
    }

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

    public async Task<PagedResult<Playlist>> GetPlaylistsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        var playlists = await _context.Playlists
            .Include(p => p.Songs)
            .ThenInclude(p => p.Owner)
            .Include(p => p.Owner)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize + 1)
            .ToListAsync(cancellationToken);

        var hasNextPage = playlists.Count > pageSize;
        if (hasNextPage)
            playlists.RemoveAt(playlists.Count - 1);

        return new PagedResult<Playlist>
        {
            Data = playlists,
            HasNextPage = hasNextPage
        };

    }

    public async Task<PagedResult<Playlist>> GetPlaylistsOfUserAsync(Guid userId, int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        var playlists = await _context.Playlists
            .Where(s => s.AuthorId == userId)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize + 1)
            .ToListAsync(cancellationToken);

        var hasNextPage = playlists.Count > pageSize;
        if (hasNextPage)
            playlists.RemoveAt(playlists.Count - 1);

        return new PagedResult<Playlist>
        {
            Data = playlists,
            HasNextPage = hasNextPage
        };
    }

    public async Task<Playlist> DeleteSongFromPlaylistAsync(Playlist playlist, Song song, CancellationToken cancellationToken)
    {
        playlist.Songs.Remove(song);

        await _context.SaveChangesAsync(cancellationToken);

        return playlist;
    }
}
