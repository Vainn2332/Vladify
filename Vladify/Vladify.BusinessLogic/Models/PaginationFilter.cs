namespace Vladify.BusinessLogic.Models;

public class PaginationFilter
{
    private const int DefaultPageNumber = 1;
    private const int DefaultPageSize = 20;
    public int PageNumber { get; set; } = DefaultPageNumber;
    public int PageSize { get; set; } = DefaultPageSize;
}
