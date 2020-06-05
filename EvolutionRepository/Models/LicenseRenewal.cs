using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class LicenseRenewal
    {
        public int LicenseID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public bool HasPaid { get; set; }
        public virtual License LicensesLicense { get; set; }
    }
}
