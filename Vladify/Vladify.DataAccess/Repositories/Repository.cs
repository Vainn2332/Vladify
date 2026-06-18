using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class Repository<TEntity>(ApplicationDbContext context) : IRepository<TEntity> where TEntity : class, IBaseEntity
{
    protected readonly ApplicationDbContext _context = context;

    public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return entity;
    }

    public virtual TEntity AddWithoutSaveChanges(TEntity entity)
    {
        var entry = _context.Set<TEntity>().Add(entity);

        return entry.Entity;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>()
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public virtual Task<TEntity?> GetByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken)
    {
        var getQuery = _context.Set<TEntity>().AsQueryable();

        if (!isTracking)
        {
            getQuery = getQuery.AsNoTracking();
        }

        return getQuery
            .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return entity;
    }
    public virtual Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Set<TEntity>().Remove(entity);

        return _context.SaveChangesAsync(cancellationToken);
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}
