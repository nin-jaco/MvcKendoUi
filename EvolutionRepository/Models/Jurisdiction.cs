using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Jurisdiction
    {
        public Jurisdiction()
        {
            this.JurisdictionsEmployeeTypeCardTypes = new List<EmployeeTypeCardType>();
            this.JurisdictionsGroups = new List<Group>();
            this.JurisdictionsOrganisations = new List<Organisation>();
            this.OrganisationJurisdictionsOrganisations = new List<Organisation>();
        }

        public int JurisdictionID { get; set; }
        public string JurisdictionName { get; set; }
        public Nullable<bool> InPreparation { get; set; }
        public Nullable<int> JurisdictionTypeID { get; set; }
        public Nullable<int> JurisdictionParentID { get; set; }
        public virtual ICollection<EmployeeTypeCardType> JurisdictionsEmployeeTypeCardTypes { get; set; }
        public virtual ICollection<Group> JurisdictionsGroups { get; set; }
        public virtual JurisdictionType JurisdictionTypesJurisdictionType { get; set; }
        public virtual ICollection<Organisation> JurisdictionsOrganisations { get; set; }
        public virtual ICollection<Organisation> OrganisationJurisdictionsOrganisations { get; set; }
    }
}
