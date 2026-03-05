namespace Vladify.BusinessLogic.ServiceInterfaces;

public interface IAuth0Service
{
    public Task<string> GetManagementTokenAsync();
    public Task DeleteUserAsync(string authId);
}
