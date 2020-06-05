using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class LicenseType
    {
        public LicenseType()
        {
            this.LicenseTypesEmployeeTypeCardTypes = new List<EmployeeTypeCardType>();
            this.LicenseTypesLicenses = new List<License>();
        }

        public int LicenseTypeID { get; set; }
        public int OrganisationID { get; set; }
        public string LicenseTypeName { get; set; }
        public decimal LicenseFee { get; set; }
        public Nullable<int> LicenseMonths { get; set; }
        public int EntityTypeID { get; set; }
        public Nullable<int> OrganisationTypeID { get; set; }
        public virtual ICollection<EmployeeTypeCardType> LicenseTypesEmployeeTypeCardTypes { get; set; }
        public virtual EntityType EntityTypesEntityType { get; set; }
        public virtual ICollection<License> LicenseTypesLicenses { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
        public virtual OrganisationType OrganisationTypesOrganisationType { get; set; }
    }
}
