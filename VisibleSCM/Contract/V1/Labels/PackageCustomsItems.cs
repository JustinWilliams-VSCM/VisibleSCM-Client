namespace VisibleSCM.Contract.V1
{
    public class PackageCustomsItem
    {
        public string PackageNumber { get; set; }
        public string ItemCode { set; get; }
        public string Description { set; get; }
        public int Quantity { set; get; }
        public decimal UnitPrice { set; get; }
        public decimal UnitWeightInLbs { set; get; }
        public string HarmonizedCode { set; get; }
        public string OriginCountryCode { set; get; }
    }
}
