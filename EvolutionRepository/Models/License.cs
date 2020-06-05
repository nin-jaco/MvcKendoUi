using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class License
    {
        public License()
        {
            this.LicensesLicenseRenewals = new List<LicenseRenewal>();
        }

        public int LicenseID { get; set; }
        public string LicenseNumber { get; set; }
        public System.DateTime IssuedDate { get; set; }
        public int OrganisationID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public int LicenseTypeID { get; set; }
        public int LicenseStatusID { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
        public virtual ICollection<LicenseRenewal> LicensesLicenseRenewals { get; set; }
        public virtual LicenseStatus LicenseStatusesLicenseStatus { get; set; }
        public virtual LicenseType LicenseTypesLicenseType { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
