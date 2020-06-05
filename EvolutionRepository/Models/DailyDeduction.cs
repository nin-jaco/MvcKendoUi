using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class DailyDeduction
    {
        public int MachineID { get; set; }
        public System.DateTime ApplicableDate { get; set; }
        public int RevenueProfileID { get; set; }
        public int SiteID { get; set; }
        public int CollectionOrganisationID { get; set; }
        public int CreditOrganisationID { get; set; }
        public float RatePercent { get; set; }
        public decimal Amount { get; set; }
    }
}
