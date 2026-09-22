namespace Vladify.DataAccess.Dtos.Pagination;

public class PagedResult<T>
{
    public required ICollection<T> Data { get; set; }

    public bool HasNextPage { get; set; }
}
