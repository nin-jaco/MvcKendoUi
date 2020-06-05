using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Site
    {
        public Site()
        {
            this.SitesCardLists = new List<CardList>();
            this.SitesSiteVisits = new List<SiteVisit>();
        }

        public int SiteID { get; set; }
        public Nullable<int> ParentManagerID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public Nullable<int> SignedByID { get; set; }
        public Nullable<System.DateTime> SignedByDate { get; set; }
        public Nullable<System.DateTime> CashCollectionTime { get; set; }
        public Nullable<int> DefaultRevenueProfileID { get; set; }
        public Nullable<int> ParentCollectorID { get; set; }
        public string LiquorLicense { get; set; }
        public byte[] TimeStamp { get; set; }
        public Nullable<int> DemographicID { get; set; }
        public Nullable<int> CardVersionNumber { get; set; }
        public string BusinessLicense { get; set; }
        public Nullable<bool> PDI { get; set; }
        public Nullable<int> PDAInvestigatorID { get; set; }
        public Nullable<int> PDAInspectorID { get; set; }
        public Nullable<short> SDLUI { get; set; }
        public virtual ICollection<CardList> SitesCardLists { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
        public virtual ICollection<SiteVisit> SitesSiteVisits { get; set; }
    }
}
