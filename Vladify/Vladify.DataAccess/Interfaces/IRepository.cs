using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface IRepository<T> where T : notnull, BaseEntity
{
    public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    public Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    public Task<IEnumerable<T>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
    public Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
}
