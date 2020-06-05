using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class RevenueProfile
    {
        public RevenueProfile()
        {
            this.RevenueProfilesLoans = new List<Loan>();
            this.RevenueProfilesRevenueScales = new List<RevenueScale>();
            this.RevenueProfilesSiteMachines = new List<SiteMachine>();
            this.OrganisationRevenuesSiteMachines = new List<SiteMachine>();
        }

        public int RevenueProfileID { get; set; }
        public string RevenueProfileName { get; set; }
        public int OrganisationID { get; set; }
        public Nullable<int> DeductionTotalTypeID { get; set; }
        public Nullable<int> AppliesOrganisationTypeID { get; set; }
        public Nullable<int> CollectOrganisationTypeID { get; set; }
        public Nullable<int> RevenueProfileTypeID { get; set; }
        public Nullable<int> DeductionTypeID { get; set; }
        public Nullable<int> CreditOrganisationTypeID { get; set; }
        public Nullable<int> IsSplit { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public virtual DeductionTotalType DeductionTotalTypesDeductionTotalType { get; set; }
        public virtual DeductionType DeductionTypesDeductionType { get; set; }
        public virtual ICollection<Loan> RevenueProfilesLoans { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
        public virtual OrganisationType OrganisationTypesOrganisationType { get; set; }
        public virtual OrganisationType OrganisationTypes1OrganisationType { get; set; }
        public virtual OrganisationType OrganisationTypes2OrganisationType { get; set; }
        public virtual RevenueProfileType RevenueProfileTypesRevenueProfileType { get; set; }
        public virtual ICollection<RevenueScale> RevenueProfilesRevenueScales { get; set; }
        public virtual ICollection<SiteMachine> RevenueProfilesSiteMachines { get; set; }
        public virtual ICollection<SiteMachine> OrganisationRevenuesSiteMachines { get; set; }
    }
}
