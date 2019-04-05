using System;
using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class ShipmentTrackingResponse
    {
        public bool HasShipped { set; get; }
        public DateTime? CarrierFirstScanDateTime { set; get; }
        public bool HasDelivered { set; get; }
        public string ReferenceNumber { set; get; }
        public string ReferenceNumber2 { set; get; }
        public decimal TotalWeight { set; get; }
        public string UofM { set; get; }
        public DateTime? PickupDate { set; get; }
        public List<ShipmentTrackingPackage> Packages { set; get; }
        public int ResultCode { set; get; }
        public string SecurityToken { set; get; }
        public double TimeInMs { set; get; }
    }
}
