using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class SiteVisit
    {
        public int SiteVisitID { get; set; }
        public int EmployeeID { get; set; }
        public int SiteID { get; set; }
        public System.DateTime ArrivalTime { get; set; }
        public Nullable<System.DateTime> DepartureTime { get; set; }
        public string Comments { get; set; }
        public virtual Site SitesSite { get; set; }
    }
}
