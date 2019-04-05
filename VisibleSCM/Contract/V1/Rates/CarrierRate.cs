using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class CarrierRate
    {
        public string ShipCarrier { set; get; }
        public List<ShipRate> Rates { set; get; }
    }
}
