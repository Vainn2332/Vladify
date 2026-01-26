using Vladify.BusinessLogic.Constants;

namespace Vladify.BusinessLogic.Models;

public record PaginationFilter(
    int PageNumber = PaginationConstants.DefaultPaginationPageNumber,
    int PageSize = PaginationConstants.DefaultPaginationPageSize
    );
