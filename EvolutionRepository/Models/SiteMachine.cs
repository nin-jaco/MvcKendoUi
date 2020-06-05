using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class SiteMachine
    {
        public SiteMachine()
        {
            this.OrganisationRevenuesRevenueProfiles = new List<RevenueProfile>();
        }

        public int SiteID { get; set; }
        public int MachineID { get; set; }
        public Nullable<int> RevenueProfileID { get; set; }
        public Nullable<int> ClusterBoxID { get; set; }
        public Nullable<short> ClusterBoxPort { get; set; }
        public bool Installed { get; set; }
        public virtual RevenueProfile RevenueProfilesRevenueProfile { get; set; }
        public virtual ICollection<RevenueProfile> OrganisationRevenuesRevenueProfiles { get; set; }
    }
}
