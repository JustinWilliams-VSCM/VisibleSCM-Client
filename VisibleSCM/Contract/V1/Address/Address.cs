namespace VisibleSCM.Contract.V1
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public string Address3 { set; get; }
        public string City { set; get; }
        public string Neighborhood { set; get; }
        public string State { set; get; }
        public string PostalCode { set; get; }
        public string Country { set; get; }
        public string Company { set; get; }
        public string PhoneNumber { set; get; }
        public string EmailAddress { set; get; }
        public bool IsResidential { set; get; }
    }
}
