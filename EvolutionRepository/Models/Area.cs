using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Area
    {
        public Area()
        {
            this.AreasDailyAreas = new List<DailyArea>();
            this.OrganisationAreasOrganisations = new List<Organisation>();
        }

        public int AreaID { get; set; }
        public int OrganisationID { get; set; }
        public string AreaName { get; set; }
        public string Telephone { get; set; }
        public string EmergencyNumber { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> Total_staff_Allocted { get; set; }
        public Nullable<int> Total_Engineers_Allocated { get; set; }
        public Nullable<int> Total_Vehicles_Allocated { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
        public virtual ICollection<DailyArea> AreasDailyAreas { get; set; }
        public virtual ICollection<Organisation> OrganisationAreasOrganisations { get; set; }
    }
}
