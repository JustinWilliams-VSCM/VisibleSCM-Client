using System;
using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class LabelRequest
    {
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public string Carrier { set; get; }
        public string ServiceType { set; get; }
        public string OrderNumber { set; get; }
        public string ServiceLevel { set; get; }
        public string PackageType { set; get; }
        public Address ShipToAddress { set; get; }
        public Address ShipFromAddress { set; get; }
        public string ShipFromPostalCode { get; set; }
        public DateTime ShipDate { set; get; }
        public List<ShipmentOption> ShipmentOptions { get; set; }
        public List<Package> Packages { set; get; }
        public PackageCustomsInformation CustomsInfo { set; get; }
        public string PreferredLabelFormat { set; get; }
        public string SecurityToken { set; get; }
        public bool ValidateAddressFirst { set; get; }
    }
}
