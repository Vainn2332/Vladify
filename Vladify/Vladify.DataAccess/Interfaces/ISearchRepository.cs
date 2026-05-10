using Vladify.DataAccess.Entities;

namespace Vladify.DataAccess.Interfaces;

public interface ISearchRepository
{
    Task<(ICollection<Song>, ICollection<User>)> SearchAsync(string query, CancellationToken cancellationToken);
}
