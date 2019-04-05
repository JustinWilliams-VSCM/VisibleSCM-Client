using System;
using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class RatesRequest
    {
        public string SubClientName { set; get; }
        public Address ShipToAddress { set; get; }
        public Address ShipFromAddress { set; get; }
        public List<string> CarrierList { set; get; }
        public List<string> ServiceTypeList { set; get; }
        public decimal WeightInLbs { set; get; }
        public string PackageType { set; get; }
        public DateTime ShipDate { set; get; }
        public decimal DeclaredValue { set; get; }
        public bool IncludeInsuranceQuote { set; get; } = false;
        public bool IncludeFirstMileLabel { set; get; } = false;
        public bool RateShopInCarrierList { set; get; } = false;
        public string ClientName { set; get; }
        public string SecurityToken { set; get; }
        public decimal Width { set; get; }
        public decimal Height { set; get; }
        public decimal Length { set; get; }
    }
}
