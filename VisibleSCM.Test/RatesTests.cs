using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using VisibleSCM.Contract.V1;

namespace VisibleSCM.Test
{
    [TestClass]
    public class RatesTests : BaseTests
    {
        private Address ToAddress, FromAddress;

        [TestInitialize]
        public void Initialize()
        {
            ToAddress = new Address()
            {
                Name = "Visible Test",
                Company = "VisibleSCM",
                Address1 = "1545 s 4800 w",
                City = "Salt Lake City",
                State = "UT",
                PostalCode = "84104",
                Country = "US",
                EmailAddress = "noreply@prostarfulfillment.com",
                PhoneNumber = "8019730989"
            };

            FromAddress = new Address()
            {
                Name = "Visible Test",
                Company = "VisibleSCM",
                Address1 = "1545 s 4800 w",
                City = "Salt Lake City",
                State = "UT",
                PostalCode = "84104",
                Country = "US",
                EmailAddress = "noreply@prostarfulfillment.com",
                PhoneNumber = "8019730989"
            };

            VisibleRequest visibleRequest = new VisibleRequest(GetLoginRequest(), "Login");
            LoginResponse loginResponse = visibleRequest.Execute<LoginResponse>();

            SecurityToken = loginResponse.SecurityToken;
        }

        [TestMethod]
        public void GetRates()
        {
            RatesRequest ratesRequest = CreateGetRatesRequest();

            VisibleRequest visibleRequest = new VisibleRequest(ratesRequest, "Rates/Retrieve");
            RatesResponse ratesResponse = visibleRequest.Execute<RatesResponse>();

            Assert.AreEqual(0, ratesResponse.ResultCode);
        }

        private RatesRequest CreateGetRatesRequest()
        {
            RatesRequest ratesRequest = new RatesRequest();
            ratesRequest.ClientName = "ProStar";
            ratesRequest.SubClientName = "";
            ratesRequest.SecurityToken = SecurityToken;
            ratesRequest.CarrierList = new List<string>() { "USPS" };
            ratesRequest.ServiceTypeList = new List<string>() { "PriorityMail" };
            ratesRequest.ShipDate = DateTime.Now.AddDays(1);
            ratesRequest.PackageType = "Package";
            ratesRequest.DeclaredValue = 20;
            ratesRequest.Height = 3;
            ratesRequest.Width = 3;
            ratesRequest.Length = 3;
            ratesRequest.WeightInLbs = 5;
            ratesRequest.ShipToAddress = ToAddress;
            ratesRequest.ShipFromAddress = FromAddress;

            return ratesRequest;
        }
    }
}
