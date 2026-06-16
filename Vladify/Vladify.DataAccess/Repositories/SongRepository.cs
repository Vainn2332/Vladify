using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class SongRepository(ApplicationDbContext context) : Repository<Song>(context), ISongRepository
{
    public override async Task<Song> AddAsync(Song song, CancellationToken cancellationToken)
    {
        await _context.Songs.AddAsync(song, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        await _context.Entry(song).Reference(p => p.Owner).LoadAsync(cancellationToken);

        return song;
    }

    public override Task<Song?> GetByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken)
    {
        var query = _context.Songs.AsQueryable();

        if (!isTracking)
        {
            query = query.AsNoTracking();
        }

        return query
            .Include(p => p.Owner)
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public override async Task<IEnumerable<Song>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Songs
            .Include(p => p.Owner)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public override async Task<Song> UpdateAsync(Song song, CancellationToken cancellationToken)
    {
        _context.Songs.Update(song);
        await _context.SaveChangesAsync(cancellationToken);

        await _context.Entry(song).Reference(p => p.Owner).LoadAsync(cancellationToken);

        return song;
    }
}
