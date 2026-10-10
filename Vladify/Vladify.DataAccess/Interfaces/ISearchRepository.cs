using Vladify.DataAccess.Dtos;

namespace Vladify.DataAccess.Interfaces;

public interface ISearchRepository
{
    public Task<SearchResult> SearchAsync(string query, CancellationToken cancellationToken);
}
