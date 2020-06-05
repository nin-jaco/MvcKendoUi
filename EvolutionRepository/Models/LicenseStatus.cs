using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class LicenseStatus
    {
        public LicenseStatus()
        {
            this.LicenseStatusesLicenses = new List<License>();
        }

        public int LicenseStatusID { get; set; }
        public string LicenseStatusName { get; set; }
        public virtual ICollection<License> LicenseStatusesLicenses { get; set; }
    }
}
