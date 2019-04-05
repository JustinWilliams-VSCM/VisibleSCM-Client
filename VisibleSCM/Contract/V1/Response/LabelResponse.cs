using System;
using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class LabelResponse
    {
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public string Carrier { set; get; }
        public string ServiceType { set; get; }
        public string OrderNumber { set; get; }
        public DateTime ShipDate { set; get; }
        public decimal ShippingCharge { set; get; }
        public string Zone { set; get; }
        public decimal BilledWeight { set; get; }
        public string TransactionNumber { set; get; }
        public List<ShippedPackage> Packages { set; get; }
        public List<AdditionalDocument> AdditionalDocuments { set; get; }
        public int ResultCode { set; get; }
        public string ResultMessage { set; get; }
        public string SecurityToken { set; get; }
        public double TimeInMs { set; get; }
        public string TrackingNumber { get; set; }
    }
}
