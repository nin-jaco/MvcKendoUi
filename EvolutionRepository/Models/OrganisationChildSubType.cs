using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationChildSubType
    {
        public int OrganisationTypeID { get; set; }
        public int OrganisationSubTypeID { get; set; }
        public virtual OrganisationType OrganisationTypesOrganisationType { get; set; }
    }
}
