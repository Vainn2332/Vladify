namespace Vladify.DataAccess.Interfaces;

public interface IRepository<T> where T : class, IEntity
{
    public Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    public Task<T?> GetByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<T>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
    public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);
    public Task DeleteAsync(T entity, CancellationToken cancellationToken);
}
