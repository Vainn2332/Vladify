using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class SongRepository(ApplicationDbContext _context) : ISongRepository
{
    public async Task<Song> AddAsync(Song song, CancellationToken ct = default)
    {
        await _context.Songs.AddAsync(song, ct);
        await _context.SaveChangesAsync(ct);

        return song;
    }

    public async Task<IEnumerable<Song>> GetAsync(int pageNumber, int pageSize, CancellationToken ct = default)
    {
        return await _context.Songs
            .AsNoTracking()
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(ct);
    }

    public async Task<Song?> GetByIdAsync(Guid songId, CancellationToken ct = default)
    {
        return await _context.Songs.AsNoTracking().FirstOrDefaultAsync(s => s.Id == songId, ct);
    }

    public async Task<Song> UpdateAsync(Song Song, CancellationToken ct = default)
    {
        _context.Songs.Update(Song);
        await _context.SaveChangesAsync(ct);

        return Song;
    }

    public async Task DeleteAsync(Song song, CancellationToken ct = default)
    {
        _context.Remove(song);

        await _context.SaveChangesAsync(ct);
    }
}
