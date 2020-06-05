using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class SiteDisabledPeriod
    {
        public int PeriodID { get; set; }
        public int SiteID { get; set; }
        public string PeriodName { get; set; }
        public int EmployeeID { get; set; }
        public int FrequencyTypeID { get; set; }
        public int FrequencyInterval { get; set; }
        public System.DateTime DisableStartDate { get; set; }
        public System.DateTime DisableEndDate { get; set; }
        public virtual FrequencyType FrequencyType { get; set; }
    }
}
