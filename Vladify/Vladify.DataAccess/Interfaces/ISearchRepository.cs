using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISearchRepository
{
    public Task<List<Song>> SearchSongsAsync(string query, int limit, CancellationToken cancellationToken);
    public Task<List<Playlist>> SearchPlaylistsAsync(string query, int limit, CancellationToken cancellationToken);
    public Task<List<User>> SearchUsersAsync(string query, int limit, CancellationToken cancellationToken);
}
