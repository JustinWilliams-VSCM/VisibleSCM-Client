namespace VisibleSCM.Contract.V1
{
    public class CancelLabelRequest
    {
        public string TrackingNumber { set; get; } = string.Empty;
        public string TransactionId { set; get; } = string.Empty;
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public string SecurityToken { set; get; }
        public string Carrier { set; get; }
    }
}
