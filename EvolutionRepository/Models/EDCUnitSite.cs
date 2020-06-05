using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EDCUnitSite
    {
        public int MachineID { get; set; }
        public int SiteID { get; set; }
        public Nullable<short> MasterEDCUnit { get; set; }
        public Nullable<short> NodeID { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
