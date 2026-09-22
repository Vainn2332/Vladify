namespace Vladify.DataAccess.Dtos.Pagination;

public class PagedResult<TData>
{
    public required ICollection<TData> Data { get; set; }

    public bool HasNextPage { get; set; }
}
