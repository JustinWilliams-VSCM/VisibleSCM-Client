using System;
using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class ShipRate
    {
        public string Carrier { set; get; }
        public string Service { set; get; }
        public string ServiceDescription { set; get; }
        public string Zone { set; get; }
        public decimal Price { set; get; }
        public string Classification { set; get; }
        public string DeliveryDays { set; get; }
        public string ToZip { set; get; }
        public string FromZip { set; get; }
        public string ToCountry { set; get; }
        public double WeightLb { set; get; }
        public double WeightOz { set; get; }
        public double Length { set; get; }
        public double Height { set; get; }
        public double Width { set; get; }
        public DateTime ShipDate { set; get; }
        public decimal InsuredValue { set; get; }
        public decimal RegisteredValue { set; get; }
        public decimal CODValue { set; get; }
        public decimal DeclaredValue { set; get; }
        public bool RectangularShaped { set; get; }
        public string Prohibitions { set; get; }
        public string Observations { set; get; }
        public string Regulations { set; get; }
        public string Restrictions { set; get; }
        public string MaxDimensions { set; get; }
        public string DimWeighting { set; get; }
        public int EffectiveWeightInOunces { set; get; }
        public int RateCategory { set; get; }
        public bool CubicPricing { set; get; }
        public string PackageType { set; get; }
        public List<ShipRateCharge> Charges { set; get; }
        public List<ShipRateOption> Options { set; get; }
        public DateTime? EstimatedDelivaryDate { get; set; }
        public List<ShippedPackage> Packages { set; get; }
    }
}
