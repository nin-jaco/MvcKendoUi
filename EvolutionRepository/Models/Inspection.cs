using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Inspection
    {
        public Inspection()
        {
            this.SiteInspectionsOrganisations = new List<Organisation>();
        }

        public int InspectionID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CreatedByID { get; set; }
        public int AreaID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime InspectionStartDate { get; set; }
        public System.DateTime InspectionEndDate { get; set; }
        public virtual ICollection<Organisation> SiteInspectionsOrganisations { get; set; }
    }
}
