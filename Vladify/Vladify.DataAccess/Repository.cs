using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class Repository<T>(ApplicationDbContext _context) : IRepository<T> where T : class, IEntity
{
    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _context.Set<T>().AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return entity;
    }

    public async Task<IEnumerable<T>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        return await _context.Set<T>()
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public async Task<T?> GetByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken = default)
    {
        var getQuery = _context.Set<T>().AsQueryable();

        if (!isTracking)
        {
            getQuery = getQuery.AsNoTracking();
        }

        return await getQuery
            .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
    }

    public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return entity;
    }
    public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
