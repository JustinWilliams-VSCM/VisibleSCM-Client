using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class RatesResponse
    {
        public List<CarrierRate> CarrierRates { set; get; }
        public ShipRate RecommendedRate { set; get; } = null;
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public int ResultCode { set; get; }
        public string ResultMessage { set; get; }
        public string SecurityToken { set; get; }
        public double TimeInMs { set; get; }
    }
}
