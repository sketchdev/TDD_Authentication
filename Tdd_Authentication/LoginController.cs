using System;

namespace Tdd_Authentication
{
    public class LoginController
    {
        public AuthenticationResponse Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return new AuthenticationResponse
                {
                    Success = false,
                    Message = "Username or password are incorrect."
                };
            }

            throw new NotImplementedException();
        }
    }
}
