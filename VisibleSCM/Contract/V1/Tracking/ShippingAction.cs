using System;

namespace VisibleSCM.Contract.V1
{
    public class ShippingAction
    {
        public DateTime? ActionDateTime { set; get; }
        public string Description { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Zip { set; get; }
        public string Country { set; get; }
        public string StatusCode { set; get; }
        public string Misc { set; get; }
        public string SignedForByName { set; get; }
    }
}
