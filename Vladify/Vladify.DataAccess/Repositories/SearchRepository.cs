using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Dtos;
using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class SearchRepository(ApplicationDbContext context) : ISearchRepository
{
    public async Task<SearchResult> SearchAsync(string query, CancellationToken cancellationToken)
    {
        var songs = await context.Songs
           .AsNoTracking()
           .Include(s => s.Owner)
           .Where(s => s.Status == SongStatus.Approved && s.Title.Contains(query))
           .OrderBy(s => s.Title).ThenBy(s => s.Id)
           .Take(SearchConstants.SongSearchResultLimit)
           .ToListAsync(cancellationToken);

        var playlists = await context.Playlists
            .AsNoTracking()
            .Include(p => p.Owner)
            .Where(p => p.Name.Contains(query))
            .OrderBy(p => p.Name).ThenBy(p => p.Id)
            .Take(SearchConstants.PlaylistSearchResultLimit)
            .ToListAsync(cancellationToken);

        var users = await context.Users
            .AsNoTracking()
            .Where(u => u.Name.Contains(query))
            .OrderBy(u => u.Name).ThenBy(u => u.Id)
            .Take(SearchConstants.UserSearchResultLimit)
            .ToListAsync(cancellationToken);

        return new SearchResult()
        {
            Songs = songs,
            Playlists = playlists,
            Users = users
        };
    }
}
