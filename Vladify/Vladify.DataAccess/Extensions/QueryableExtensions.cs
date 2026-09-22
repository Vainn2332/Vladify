using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Dtos.Pagination;

namespace Vladify.DataAccess.Extensions;

public static class QueryableExtensions
{
    /// <summary>
    /// Materializes a single page from an ordered query. Fetches one extra row to
    /// determine whether a next page exists, then drops it from the returned data.
    /// The query must already be ordered (Skip requires a stable ordering).
    /// </summary>
    public static async Task<PagedResult<T>> ToPagedResultAsync<T>(
        this IQueryable<T> query, int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize + 1)
            .ToListAsync(cancellationToken);

        var hasNextPage = items.Count > pageSize;
        if (hasNextPage)
            items.RemoveAt(items.Count - 1);

        return new PagedResult<T>
        {
            Data = items,
            HasNextPage = hasNextPage
        };
    }
}
