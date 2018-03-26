using System;
using System.Collections.Generic;
using System.Text;
using Tdd_Authentication;

namespace Tdd_Authentication_Tests.Mocks
{
    public class AllUsersValid_AuthenticationService : IAuthenticationService
    {
        public AuthenticationServiceResponse Authenticate(string username, string password)
        {
            return AuthenticationServiceResponse.Ok;
        }
    }
}
