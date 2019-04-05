namespace VisibleSCM.Contract.V1
{
    public class VSCMUser
    {
        public int UserId { set; get; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string SessionId { set; get; }
        public string EmailAddress { set; get; }
        public string UserFullName { set; get; }
    }
}
