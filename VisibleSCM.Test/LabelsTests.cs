using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using VisibleSCM.Contract.V1;

namespace VisibleSCM.Test
{
    [TestClass]
    public class LabelsTests : BaseTests
    {
        private Address ToAddress, FromAddress;
        private List<ShipmentOption> ShipmentOptions;
        private List<Package> Packages;
        private PackageCustomsInformation PackageCustoms;

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

            ShipmentOptions = new List<ShipmentOption>()
            {
                new ShipmentOption()
                {
                    Option = "COMMERCIAL INVOICE",
                    OptionValue = "FALSE"
                }
            };

            Packages = new List<Package>()
            {
                new Package()
                {
                    Width = 3,
                    Height = 3,
                    Length = 3,
                    PackageNumber = 1,
                    WeightInLbs = 5
                }
            };

            PackageCustoms = new PackageCustomsInformation()
            {
                CustomsItems = new List<PackageCustomsItem>()
                {
                    new PackageCustomsItem()
                    {
                        PackageNumber = "1",
                        Quantity = 1,
                        UnitPrice = 20,
                        UnitWeightInLbs = 5,
                        Description = "Item description"
                    }
                },
                Value = "20",
                CurrencyCode = "USD"
            };

            VisibleRequest visibleRequest = new VisibleRequest(GetLoginRequest(), "Login");
            LoginResponse loginResponse = visibleRequest.Execute<LoginResponse>();

            SecurityToken = loginResponse.SecurityToken;
        }

        [TestMethod]
        public void CreateLabel()
        {
            LabelRequest labelRequest = CreateLabelRequest();

            VisibleConfig config = new VisibleConfig(VisibleVersion.V1, VisibleEnvironment.Sandbox);
            VisibleRequest visibleRequest = new VisibleRequest(labelRequest, "Label/Create", config);
            LabelResponse labelResponse = visibleRequest.Execute<LabelResponse>();

            Assert.AreEqual(0, labelResponse.ResultCode);
        }

        [TestMethod]
        public void CancelLabel()
        {
            CancelLabelRequest cancelLabelRequest = CreateCancelLabelRequest("0405510200882103615281");

            VisibleRequest visibleRequest = new VisibleRequest(cancelLabelRequest, "Label/Cancel");
            CancelLabelResponse cancelLabelResponse = visibleRequest.Execute<CancelLabelResponse>();

            Assert.AreEqual(0, cancelLabelResponse.ResultCode);
        }

        [TestMethod]
        public void CreateAndCancelLabel()
        {
            // Create label
            LabelRequest labelRequest = CreateLabelRequest();
            VisibleRequest visibleRequest = new VisibleRequest(labelRequest, "Label/Create");
            LabelResponse labelResponse = visibleRequest.Execute<LabelResponse>();

            Assert.AreEqual(0, labelResponse.ResultCode);

            // Cancel label
            CancelLabelRequest cancelLabelRequest = CreateCancelLabelRequest(labelResponse.TrackingNumber);
            visibleRequest = new VisibleRequest(cancelLabelRequest, "Label/Cancel");
            CancelLabelResponse cancelLabelResponse = visibleRequest.Execute<CancelLabelResponse>();

            Assert.AreEqual(0, cancelLabelResponse.ResultCode);
        }

        [TestMethod]
        public void TrackShipment()
        {
            ShipmentTrackingRequest trackingRequest = CreateTrackingRequest("0405510200882103615281");

            VisibleRequest visibleRequest = new VisibleRequest(trackingRequest, "Shipment/Track");
            ShipmentTrackingResponse trackingResponse = visibleRequest.Execute<ShipmentTrackingResponse>();

            Assert.AreEqual(0, trackingResponse.ResultCode);
        }

        [TestMethod]
        public void CreateAndTrackShipment()
        {
            // Create label
            LabelRequest labelRequest = CreateLabelRequest();
            VisibleRequest visibleRequest = new VisibleRequest(labelRequest, "Label/Create");
            LabelResponse labelResponse = visibleRequest.Execute<LabelResponse>();

            Assert.AreEqual(0, labelResponse.ResultCode);

            // Track Shipment
            ShipmentTrackingRequest trackingRequest = CreateTrackingRequest(labelResponse.TrackingNumber);
            visibleRequest = new VisibleRequest(trackingRequest, "Shipment/Track");
            ShipmentTrackingResponse trackingResponse = visibleRequest.Execute<ShipmentTrackingResponse>();

            Assert.AreEqual(0, trackingResponse.ResultCode);
        }

        [TestMethod]
        public void ManifestShipment()
        {
            ShippingManifestRequest manifestRequest = CreateManifestRequest("0405510200882103615281");

            VisibleRequest visibleRequest = new VisibleRequest(manifestRequest, "ShippingManifest/Create");
            ShippingManifestResponse manifestResponse = visibleRequest.Execute<ShippingManifestResponse>();

            Assert.AreEqual(0, manifestResponse.ResultCode);
        }

        [TestMethod]
        public void CreateAndManifestShipment()
        {
            // Create label
            LabelRequest labelRequest = CreateLabelRequest();
            VisibleRequest visibleRequest = new VisibleRequest(labelRequest, "Label/Create");
            LabelResponse labelResponse = visibleRequest.Execute<LabelResponse>();

            Assert.AreEqual(0, labelResponse.ResultCode);

            // Manifest Shipment
            ShippingManifestRequest manifestRequest = CreateManifestRequest(labelResponse.TrackingNumber);
            visibleRequest = new VisibleRequest(manifestRequest, "ShippingManifest/Create");
            ShippingManifestResponse manifestResponse = visibleRequest.Execute<ShippingManifestResponse>();

            Assert.AreEqual(0, manifestResponse.ResultCode);
        }

        private LabelRequest CreateLabelRequest()
        {
            LabelRequest labelRequest = new LabelRequest();
            labelRequest.ClientName = "ProStar";
            labelRequest.SubClientName = "";
            labelRequest.SecurityToken = SecurityToken;
            labelRequest.Carrier = "USPS";
            labelRequest.ServiceType = "PriorityMail";
            labelRequest.ShipDate = DateTime.Now.AddDays(1);
            labelRequest.OrderNumber = string.Concat("VSCMClient-", DateTime.Now.ToString("yyyyMMddHHmmss"));
            labelRequest.PreferredLabelFormat = "PNG";
            labelRequest.Packages = Packages;
            labelRequest.PackageType = "Package";
            labelRequest.CustomsInfo = PackageCustoms;
            labelRequest.ShipToAddress = ToAddress;
            labelRequest.ShipFromAddress = FromAddress;
            labelRequest.ShipFromPostalCode = labelRequest.ShipFromAddress.PostalCode;
            labelRequest.ShipmentOptions = ShipmentOptions;

            return labelRequest;
        }

        private CancelLabelRequest CreateCancelLabelRequest(string trackingNumber = "")
        {
            CancelLabelRequest labelRequest = new CancelLabelRequest();
            labelRequest.ClientName = "ProStar";
            labelRequest.SubClientName = "";
            labelRequest.SecurityToken = SecurityToken;
            labelRequest.Carrier = "USPS";
            labelRequest.TrackingNumber = trackingNumber;

            return labelRequest;
        }

        private ShipmentTrackingRequest CreateTrackingRequest(string trackingNumber = "")
        {
            ShipmentTrackingRequest trackingRequest = new ShipmentTrackingRequest();
            trackingRequest.ClientName = "ProStar";
            trackingRequest.SecurityToken = SecurityToken;
            trackingRequest.Carrier = "USPS";
            trackingRequest.TrackingNumber = trackingNumber;

            return trackingRequest;
        }

        private ShippingManifestRequest CreateManifestRequest(string trackingNumber = "")
        {
            ShippingManifestRequest manifestRequest = new ShippingManifestRequest();
            manifestRequest.ClientName = "ProStar";
            manifestRequest.SubClientName = "";
            manifestRequest.SecurityToken = SecurityToken;
            manifestRequest.Carrier = "USPS";
            manifestRequest.Manifest = new ShippingManifest()
            {
                TrackingNumbers = new List<string>() { trackingNumber },
                InductionPostalCode = FromAddress.PostalCode,
                ShipFromAddress = FromAddress,
                NumberOfPallets = 1,
            };

            return manifestRequest;
        }
    }
}
