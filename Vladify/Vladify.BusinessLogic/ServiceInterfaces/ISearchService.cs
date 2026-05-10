using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface ISearchService
{
    public Task<SearchResultDto> SearchAsync(string query, CancellationToken cancellationToken);
}
