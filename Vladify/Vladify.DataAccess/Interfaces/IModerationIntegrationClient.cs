using Vladify.DataAccess.Dtos;

namespace Vladify.DataAccess.Interfaces;

public interface IModerationIntegrationClient
{
    public Task<ModerationTaskDto> CreateTaskAsync(string songId, CancellationToken cancellationToken);
}
