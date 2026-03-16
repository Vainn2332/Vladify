namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IAuth0Service
{
    public Task DeleteUserAsync(string authId);
}
