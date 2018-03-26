using System;

namespace Tdd_Authentication
{
    public class LoginController
    {
        IAuthenticationService _authenticationService;

        public LoginController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        
        public AuthenticationResponse Authenticate(string username, string password)
        {
            if (IsInputInvalid(username, password))
            {
                return new AuthenticationResponse
                {
                    Success = false,
                    Message = "Username or password are incorrect."
                };
            }

            AuthenticationServiceResponse authenticationReponse = _authenticationService.Authenticate(username, password);

            if (authenticationReponse == AuthenticationServiceResponse.Ok)
                return new AuthenticationResponse
                {
                    Success = true,
                    Message = "Login Succeeded."
                };
            else
            {
                return new AuthenticationResponse
                {
                    Success = false,
                    Message = "Username or password are incorrect."
                };
            }
        }


        private static bool IsInputInvalid(string username, string password)
        {
            return string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password);
        }
    }
}
