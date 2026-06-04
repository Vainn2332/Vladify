using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface IPlaylistRepository : IRepository<Playlist>
{
    public Task<Playlist> AddSongToPlaylistAsync(Playlist playlist, Song song, CancellationToken cancellationToken);
    public Task<Playlist?> GetPlaylistAsync(Guid id, bool isTracking, CancellationToken cancellationToken);
    public Task<IEnumerable<Playlist>> GetPlaylistsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
    public Task<IEnumerable<Playlist>> GetPlaylistsOfUserAsync(Guid userId, int pageNumber, int pageSize, CancellationToken cancellationToken);
    public Task<Playlist> DeleteSongFromPlaylistAsync(Playlist playlist, Song song, CancellationToken cancellationToken);

}