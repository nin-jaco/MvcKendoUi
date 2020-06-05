using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineDeduction
    {
        public int FiscalYearID { get; set; }
        public int FiscalPeriodID { get; set; }
        public int MachineID { get; set; }
        public int SiteID { get; set; }
        public int RevenueProfileID { get; set; }
        public int CollectionOrganisationID { get; set; }
        public int CreditOrganisationID { get; set; }
        public float RatePercent { get; set; }
        public decimal Amount { get; set; }
        public virtual MachineTotal MachineTotalsMachineTotal { get; set; }
    }
}
