using Microsoft.EntityFrameworkCore;
using Vladify.DataAccess.Dtos.Pagination;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
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

    public Task<Song?> GetApprovedSongByIdAsync(Guid songId, bool isTracking, CancellationToken cancellationToken)
    {
        var query = _context.Songs.AsQueryable();

        if (!isTracking)
        {
            query = query.AsNoTracking();
        }

        return query
            .Include(p => p.Owner)
            .FirstOrDefaultAsync(u => u.Id == songId && u.Status == SongStatus.Approved, cancellationToken);
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

    public override async Task<PagedResult<Song>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        var songs = await _context.Songs
            .Where(s => s.Status == SongStatus.Approved)
            .Include(p => p.Owner)
            .OrderBy(p => p.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        var hasNextPage = songs.Count > pageSize;
        if (hasNextPage)
            songs.RemoveAt(songs.Count - 1);

        return new PagedResult<Song>
        {
            Data = songs,
            HasNextPage = hasNextPage
        };
    }

    public override async Task<Song> UpdateAsync(Song song, CancellationToken cancellationToken)
    {
        _context.Songs.Update(song);
        await _context.SaveChangesAsync(cancellationToken);

        await _context.Entry(song).Reference(p => p.Owner).LoadAsync(cancellationToken);

        return song;
    }
}
