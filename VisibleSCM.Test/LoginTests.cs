using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using VisibleSCM.Contract.V1;

namespace VisibleSCM.Test
{
    [TestClass]
    public class LoginTests : BaseTests
    {

        [TestMethod]
        public void Login()
        {
            LoginRequest loginRequest = GetLoginRequest();

            //VisibleConfig config = new VisibleConfig(VisibleVersion.V1, VisibleEnvironment.Sandbox);
            //VisibleRequest visibleRequest = new VisibleRequest(loginRequest, "Login", config);

            VisibleRequest visibleRequest = new VisibleRequest(loginRequest, "Login");
            LoginResponse loginResponse = visibleRequest.Execute<LoginResponse>();

            Assert.AreEqual(0, loginResponse.ResultCode);
        }
    }
}
