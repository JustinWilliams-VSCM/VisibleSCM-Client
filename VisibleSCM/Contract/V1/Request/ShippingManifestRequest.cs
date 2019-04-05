namespace VisibleSCM.Contract.V1
{
    public class ShippingManifestRequest
    {
        public ShippingManifest Manifest { set; get; }
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public string SecurityToken { set; get; }
        public int SessionID { set; get; }
        public string Carrier { set; get; }
    }
}
