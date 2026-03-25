namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IAuth0Service
{
    public Task DeleteUserFromAuth0Async(string authId);
}
