namespace Tdd_Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationServiceResponse Authenticate(string username, string password);
    }
}