using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tdd_Authentication;

namespace Tdd_Authentication_Tests
{
    [TestClass]
    public class AuthenticationFailed_Tests
    {
        [TestMethod]
        public void TestEmptyUser_EmptyPassword_FailsAuthentication()
        {
            var username = "";
            var password = "";

            LoginController loginController = new LoginController();

            AuthenticationResponse authenticationResponse = loginController.Authenticate(username, password);

            Assert.IsFalse(authenticationResponse.Success);
            Assert.AreEqual("Username or password are incorrect.", authenticationResponse.Message);
            
        }
    }
}
