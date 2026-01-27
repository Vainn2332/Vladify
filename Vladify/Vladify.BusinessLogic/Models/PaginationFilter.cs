namespace Vladify.BusinessLogic.Models;

file static class Constraints
{
    public const int DefaultPaginationPageNumber = 1;

    public const int DefaultPaginationPageSize = 20;
}

public record PaginationFilter(
    int PageNumber = Constraints.DefaultPaginationPageNumber,
    int PageSize = Constraints.DefaultPaginationPageSize
    );
