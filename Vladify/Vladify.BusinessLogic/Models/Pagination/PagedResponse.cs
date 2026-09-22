namespace Vladify.BusinessLogic.Models.Pagination;

public class PagedResponse<TResponse>
{
    public required IReadOnlyCollection<TResponse> Data { get; set; }

    public bool HasNextPage { get; set; }
}
