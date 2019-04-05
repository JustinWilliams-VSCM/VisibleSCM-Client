using System.Collections.Generic;

namespace VisibleSCM.Contract.V1
{
    public class PackageCustomsInformation
    {
        public string ReasonForExport { set; get; }
        public string Comments { set; get; }
        public string InvoiceNumber { set; get; }
        public string ImporterCustomsReference { set; get; }
        public string InsuredNumber { set; get; }
        public string Value { set; get; }
        public string CurrencyCode { set; get; }
        public string LicenseNumber { set; get; }
        public string CertificateNumber { set; get; }
        public List<PackageCustomsItem> CustomsItems { set; get; } = new List<PackageCustomsItem>();
    }
}
