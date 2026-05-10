using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Constants;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

internal class SearchRepository(ApplicationDbContext context) : ISearchRepository
{
    public async Task<(ICollection<Song>, ICollection<User>)> SearchAsync(string query, CancellationToken cancellationToken)
    {
        var originalQuery = query.ToLower();

        var songs = await context.Songs
            .Include(p => p.Owner)
            .Where(p => p.Title.ToLower().Contains(originalQuery))
            .Take(DataAccessLayerConstants.SongSearchAmount)
            .ToListAsync(cancellationToken);

        var users = await context.Users
            .Where(p => p.Name.ToLower().Contains(originalQuery))
            .Take(DataAccessLayerConstants.UserSearchAmount)
            .ToListAsync(cancellationToken);

        return (songs, users);
    }
}
