namespace VisibleSCM.Contract.V1
{
    public class LoginResponse
    {
        public VSCMUser User { set; get; }
        public int ResultCode { set; get; }
        public string ResultMessage { set; get; }
        public string SecurityToken { set; get; }
        public double TimeInMs { set; get; }
    }
}
