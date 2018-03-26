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
        public void TestEmptyUser_EmptyPassword_Fails()
        {
            var username = "";
            var password = "";

            LoginController loginController = new LoginController();

            AuthenticationResponse authenticationResponse = loginController.Authenticate(username, password);

            Assert.IsFalse(authenticationResponse.Success);
            Assert.AreEqual("Username or password are incorrect.", authenticationResponse.Message);
            
        }

        [TestMethod]
        public void TestNonEmptyUser_EmptyPassword_Fails()
        {
            var username = "username";
            var password = "";

            LoginController loginController = new LoginController();

            AuthenticationResponse authenticationResponse = loginController.Authenticate(username, password);

            Assert.IsFalse(authenticationResponse.Success);
            Assert.AreEqual("Username or password are incorrect.", authenticationResponse.Message);

        }

        [TestMethod]
        public void TestEmptyUser_NonEmptyPassword_Fails()
        {
            var username = "";
            var password = "password";

            LoginController loginController = new LoginController();

            AuthenticationResponse authenticationResponse = loginController.Authenticate(username, password);

            Assert.IsFalse(authenticationResponse.Success);
            Assert.AreEqual("Username or password are incorrect.", authenticationResponse.Message);

        }
    }
}
