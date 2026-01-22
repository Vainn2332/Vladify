using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class SongRepository(ApplicationDbContext _context) : ISongRepository
{
    public async Task<Song> AddAsync(Song song)
    {
        await _context.Songs.AddAsync(song);
        await _context.SaveChangesAsync();

        return song;
    }

    public async Task<IEnumerable<Song>> GetAsync(int pageNumber, int pageSize)
    {
        return await _context.Songs
            .AsNoTracking()
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<Song?> GetByIdAsync(Guid songId)
    {
        return await _context.Songs.AsNoTracking().FirstOrDefaultAsync(s => s.Id == songId);
    }

    public async Task<Song> UpdateAsync(Song Song)
    {
        _context.Songs.Update(Song);
        await _context.SaveChangesAsync();

        return Song;
    }

    public async Task DeleteAsync(Song song)
    {
        _context.Remove(song);

        await _context.SaveChangesAsync();
    }
}
