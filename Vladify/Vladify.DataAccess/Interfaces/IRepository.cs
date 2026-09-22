using Vladify.DataAccess.Dtos.Pagination;

namespace Vladify.DataAccess.Interfaces;

public interface IRepository<TEntity> where TEntity : class, IBaseEntity
{
    public Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
    public TEntity AddWithoutSaveChanges(TEntity entity);
    public Task<TEntity?> GetByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken);
    public Task<PagedResult<TEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
    public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
    public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);
    public Task SaveChangesAsync(CancellationToken cancellationToken);
}
