using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationSubType
    {
        public int OrganisationSubTypeID { get; set; }
        public int OrganisationTypeID { get; set; }
        public string OrganisationSubTypeName { get; set; }
        public virtual OrganisationType OrganisationTypesOrganisationType { get; set; }
    }
}
