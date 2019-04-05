namespace VisibleSCM.Contract.V1
{
    public class CancelLabelResponse
    {
        public string TrackingNumber { set; get; }
        public string Status { get; set; }
        public decimal Amount { set; get; }
        public string ClientName { set; get; }
        public string SubClientName { set; get; }
        public int ResultCode { set; get; }
        public string ResultMessage { set; get; }
        public string SecurityToken { set; get; }
        public double TimeInMs { set; get; }
    }
}
