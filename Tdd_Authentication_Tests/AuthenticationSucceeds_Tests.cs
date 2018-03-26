using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tdd_Authentication;

namespace Tdd_Authentication_Tests
{
    [TestClass]
    public class AuthenticationSucceeds_Tests
    {
        [TestMethod]
        public void ValidUsername_ValidPassword()
        {
            var username = "username";
            var password = "password";

            var loginController = new LoginController(new Mocks.AllUsersValid_AuthenticationService());

            var authenticationResult = loginController.Authenticate(username, password);

            Assert.IsTrue(authenticationResult.Success);
            Assert.AreEqual("Login Succeeded.", authenticationResult.Message);
        }
    }
}
