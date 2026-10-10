using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISearchService
{
    public Task<SearchResult> SearchAsync(SearchFilter filter, CancellationToken cancellationToken);
}
