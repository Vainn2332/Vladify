using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class SongRepository(ApplicationDbContext _context) : ISongRepository
{
    public async Task<Song> AddAsync(Song song, CancellationToken cancellationToken = default)
    {
        await _context.Songs.AddAsync(song, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return song;
    }

    public async Task<IEnumerable<Song>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        return await _context.Songs
            .AsNoTracking()
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public async Task<Song?> GetByIdAsync(Guid songId, CancellationToken cancellationToken = default)
    {
        return await _context.Songs.AsNoTracking().FirstOrDefaultAsync(s => s.Id == songId, cancellationToken);
    }

    public async Task<Song> UpdateAsync(Song Song, CancellationToken cancellationToken = default)
    {
        _context.Songs.Update(Song);
        await _context.SaveChangesAsync(cancellationToken);

        return Song;
    }

    public async Task DeleteAsync(Song song, CancellationToken cancellationToken = default)
    {
        _context.Remove(song);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
