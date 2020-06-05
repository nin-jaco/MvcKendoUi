using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationDeduction
    {
        public int OrganisationID { get; set; }
        public int RevenueProfileID { get; set; }
        public int FiscalYearID { get; set; }
        public int FiscalPeriodID { get; set; }
        public int CollectionOrganisationID { get; set; }
        public int CreditOrganisationID { get; set; }
        public float RatePercent { get; set; }
        public decimal Amount { get; set; }
        public virtual FiscalPeriod FiscalPeriodsFiscalPeriod { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
