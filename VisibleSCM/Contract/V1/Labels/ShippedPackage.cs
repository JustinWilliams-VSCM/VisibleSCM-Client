namespace VisibleSCM.Contract.V1
{
    public class ShippedPackage
    {
        public int PackageNumber { get; set; }
        public decimal WeightInLbs { get; set; }
        public string PackageContent { set; get; }
        public PackageShippingLabel PackageShippingLabel { get; set; }
    }
}
