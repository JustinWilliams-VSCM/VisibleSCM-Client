using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class ShippingManifest
    {
        public List<string> OrderNumbers { set; get; } = new List<string>();
        public List<string> TrackingNumbers { set; get; } = new List<string>();
        public int NumberOfPallets { set; get; } = 0;
        public Address ShipFromAddress { set; get; }
        public string InductionPostalCode { set; get; }
    }
}
