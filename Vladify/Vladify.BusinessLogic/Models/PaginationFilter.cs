using Vladify.BusinessLogic.Constants;

namespace Vladify.BusinessLogic.Models;

public class PaginationFilter
{
    public int PageNumber { get; set; } = BLLConstants.DefaultPaginationPageNumber;
    public int PageSize { get; set; } = BLLConstants.DefaultPaginationPageSize;
}
