using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationTypeCardType
    {
        public int JurisdictionID { get; set; }
        public int OrganisationTypeID { get; set; }
        public int CardTypeID { get; set; }
        public Nullable<int> RequiredLicenseTypeID { get; set; }
    }
}
