using System;
using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class ShipmentTrackingPackage
    {
        public string TrackingNumber { set; get; }
        public DateTime? CarrierFirstScanDateTime { set; get; }
        public DateTime? EstimatedDeliveryDate { set; get; }
        public DateTime? DeliveryDate { set; get; }
        public DateTime? ShipDate { get; set; }
        public int? EstimatedTransitDays { set; get; }
        public int? ActualTransitDays { set; get; }
        public string ReferenceNumber { set; get; }
        public string ReferenceNumber2 { set; get; }
        public int ShipZone { set; get; }
        public string ServiceDescription { set; get; }
        public bool HasShipped { set; get; }
        public bool HasDelivered { set; get; }
        public string ShippingStatus { set; get; }
        public decimal PackageWeightInLbs { set; get; }
        public List<ShippingAction> Actions { set; get; }
        public List<string> AlternateTrackingNumbers { set; get; }
    }
}
