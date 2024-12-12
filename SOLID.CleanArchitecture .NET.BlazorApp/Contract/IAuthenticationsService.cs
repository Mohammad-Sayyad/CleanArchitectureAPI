namespace SOLID.CleanArchitecture_.NET.BlazorApp.Contract
{
    public interface IAuthenticationsService
    {
        Task<bool> AuthenticateAsync(string email, string password);
        Task<bool> RegisterAsync(string firstName, string lastName, string userName, string email, string password);
        Task Logout();
    }
}
