namespace VisibleSCM.Contract.V1
{
    public class ShippingManifestResponse
    {
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public int ResultCode { set; get; }
        public string ResultMessage { set; get; }
        public string SecurityToken { set; get; }
        public double TimeInMs { set; get; }
        public string ResultPath { set; get; }
        public string ManifestDocumentId { get; set; }
        public string ManifestDocument { get; set; }
        public string ManifestDocumentType { get; set; }
    }
}
