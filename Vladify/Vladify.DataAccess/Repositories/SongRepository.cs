using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.DataAccess.Repositories;

public class SongRepository(ApplicationDbContext context) : Repository<Song>(context), ISongRepository
{
    public Task<Song?> GetSongWithUserInfoByIdAsync(Guid id, bool isTracking, CancellationToken cancellationToken)
    {
        return (isTracking ? _context.Songs : _context.Songs.AsNoTracking())
            .Include(p => p.Owner)
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Song>> GetSongsWithUserInfoByIdAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Songs
            .Include(p => p.Owner)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public async Task<Song> AddSongAsync(Song song, CancellationToken cancellationToken)
    {
        await _context.Songs.AddAsync(song, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        await _context.Entry(song).Reference(p => p.Owner).LoadAsync(cancellationToken);

        return song;
    }

    public async Task<Song> UpdateSongAsync(Song song, CancellationToken cancellationToken)
    {
        _context.Songs.Update(song);
        await _context.SaveChangesAsync(cancellationToken);

        await _context.Entry(song).Reference(p => p.Owner).LoadAsync(cancellationToken);

        return song;
    }

    public async Task<IEnumerable<Song>> GetSongsOfUserAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await _context.Songs.Where(p => p.AuthorId == userId).ToListAsync(cancellationToken);
    }
}