using System;

namespace VisibleSCM.Contract.V1
{
    public class ShipmentTrackingRequest
    {
        public string TrackingNumber { set; get; }
        public string ClientName { set; get; }
        public string SecurityToken { set; get; }
        public string Carrier { set; get; }
    }
}
