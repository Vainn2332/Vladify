using Vladify.BusinessLogic.Constants;

namespace Vladify.BusinessLogic.Models;

public record PaginationFilter(
    int PageNumber = BLLConstants.DefaultPaginationPageNumber,
    int PageSize = BLLConstants.DefaultPaginationPageSize
    );
