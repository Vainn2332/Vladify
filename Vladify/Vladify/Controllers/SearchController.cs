using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.ServiceInterfaces;

namespace Vladify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SearchController(ISearchService searchService) : ControllerBase
    {
        [HttpGet]
        public Task<SearchResultDto> SearchAsync([FromQuery] string query, CancellationToken cancellationToken)
        {
            return searchService.SearchAsync(query, cancellationToken);
        }
    }
}
