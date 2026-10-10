using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class SearchRepository(ApplicationDbContext context) : ISearchRepository
{
    public Task<List<Song>> SearchSongsAsync(string query, int limit, CancellationToken cancellationToken)
    {
        return context.Songs
            .AsNoTracking()
            .Include(s => s.Owner)
            .Where(s => s.Status == SongStatus.Approved && s.Title.Contains(query))
            .OrderBy(s => s.Title).ThenBy(s => s.Id)
            .Take(limit)
            .ToListAsync(cancellationToken);
    }

    public Task<List<Playlist>> SearchPlaylistsAsync(string query, int limit, CancellationToken cancellationToken)
    {
        return context.Playlists
            .AsNoTracking()
            .Where(p => p.Name.Contains(query))
            .OrderBy(p => p.Name).ThenBy(p => p.Id)
            .Take(limit)
            .ToListAsync(cancellationToken);
    }

    public Task<List<User>> SearchUsersAsync(string query, int limit, CancellationToken cancellationToken)
    {
        return context.Users
            .AsNoTracking()
            .Where(u => u.Name.Contains(query))
            .OrderBy(u => u.Name).ThenBy(u => u.Id)
            .Take(limit)
            .ToListAsync(cancellationToken);
    }
}
