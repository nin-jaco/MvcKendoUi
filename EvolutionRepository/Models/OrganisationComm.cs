using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationComm
    {
        public int OrganisationCommID { get; set; }
        public int OrganisationID { get; set; }
        public int OrganisationCommTypeID { get; set; }
        public string Address { get; set; }
        public string AddressPrefix { get; set; }
        public Nullable<short> CommsHoneymoon { get; set; }
        public virtual OrganisationCommType OrganisationCommTypesOrganisationCommType { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
