using Vladify.DataAccess.Dtos;
using Vladify.DataAccess.Interfaces;
using Vladify.GrpcContracts;

namespace Vladify.DataAccess.Clients;

public class ModerationIntegrationClient(ModerationGrpc.ModerationGrpcClient client) : IModerationIntegrationClient
{
    public async Task<ModerationTaskDto> CreateTaskAsync(string songId, CancellationToken cancellationToken)
    {
        var request = new CreateTaskRequest()
        {
            SongId = songId
        };

        var response = await client.CreateTaskAsync(request, cancellationToken: cancellationToken);
        if (!Guid.TryParse(response.TaskId, out var id))
        {
            throw new ArgumentException("Invalid Id!");
        }

        return new ModerationTaskDto() { Id = id };
    }
}
