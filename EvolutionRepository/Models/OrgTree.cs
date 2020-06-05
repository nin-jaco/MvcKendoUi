using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrgTree
    {
        public int TopOrganisationID { get; set; }
        public int OrganisationID { get; set; }
        public string OrganisationName { get; set; }
        public Nullable<int> OrganisationTypeID { get; set; }
        public Nullable<int> OrganisationSubTypeID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> JurisdictionID { get; set; }
        public Nullable<int> OrganisationStatusID { get; set; }
        public string ContactName { get; set; }
    }
}
