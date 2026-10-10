using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Filters;

namespace Vladify.Controllers;

[Route("api/search")]
[ApiController]
[Authorize]
public class SearchController(ISearchService _searchService) : ControllerBase
{
    [HttpGet, ValidationFilter]
    public Task<SearchResult> Search(
        [FromQuery] SearchFilter filter,
        CancellationToken cancellationToken = default)
    {
        return _searchService.SearchAsync(filter, cancellationToken);
    }
}
