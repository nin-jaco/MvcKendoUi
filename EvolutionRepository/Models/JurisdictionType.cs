using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class JurisdictionType
    {
        public JurisdictionType()
        {
            this.JurisdictionTypesJurisdictions = new List<Jurisdiction>();
        }

        public int JurisdictionTypeID { get; set; }
        public string JurisdictionTypeName { get; set; }
        public virtual ICollection<Jurisdiction> JurisdictionTypesJurisdictions { get; set; }
    }
}
