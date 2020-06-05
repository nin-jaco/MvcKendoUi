using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EmployeeTypeCardType
    {
        public int JurisdictionID { get; set; }
        public int EmployeeTypeID { get; set; }
        public int CardTypeID { get; set; }
        public Nullable<int> RequiredLicenseTypeID { get; set; }
        public virtual CardType CardTypesCardType { get; set; }
        public virtual EmployeeType EmployeeTypesEmployeeType { get; set; }
        public virtual Jurisdiction JurisdictionsJurisdiction { get; set; }
        public virtual LicenseType LicenseTypesLicenseType { get; set; }
    }
}
