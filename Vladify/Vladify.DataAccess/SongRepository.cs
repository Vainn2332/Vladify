using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess;

public class SongRepository(ApplicationDbContext _context) : ISongRepository
{
    public async Task AddAsync(Song song)
    {
        await _context.Songs.AddAsync(song);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid songId)
    {
        var song = await GetByIdAsync(songId);
        if (song is not null)
        {
            await _context.Songs.Where(s => s.Id == songId).ExecuteDeleteAsync();
        }
    }

    public async Task<IEnumerable<Song>> GetAsync()
    {
        return await _context.Songs.AsNoTracking().ToListAsync();
    }

    public async Task<Song?> GetByIdAsync(Guid songId)
    {
        return await _context.Songs.FindAsync(songId);
    }

    public async Task UpdateAsync(Song newSong)
    {
        await _context.Songs.Where(p => p.Id == newSong.Id)
            .ExecuteUpdateAsync(setters => setters
            .SetProperty(p => p.Title, newSong.Title)
            .SetProperty(p => p.Album, newSong.Album)
            .SetProperty(p => p.Author, newSong.Author)
            .SetProperty(p => p.Duration, newSong.Duration));
    }
}
