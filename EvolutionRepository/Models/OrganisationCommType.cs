using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationCommType
    {
        public OrganisationCommType()
        {
            this.OrganisationCommTypesOrganisationComms = new List<OrganisationComm>();
        }

        public int OrganisationCommTypeID { get; set; }
        public string OrganisationCommTypeName { get; set; }
        public virtual ICollection<OrganisationComm> OrganisationCommTypesOrganisationComms { get; set; }
    }
}
