using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditOrganisationDeduction
    {
        public int AuditOrganisationID { get; set; }
        public int AuditRevenueProfileID { get; set; }
        public string AuditRevenueProfileName { get; set; }
        public int AuditFiscalYearID { get; set; }
        public int AuditFiscalPeriodID { get; set; }
        public Nullable<int> DeductionTotalTypeID { get; set; }
        public string DeductionTotalTypeName { get; set; }
        public int AuditCollectionOrganisationID { get; set; }
        public int AuditCreditOrganisationID { get; set; }
        public double RatePercent { get; set; }
        public decimal Amount { get; set; }
        public virtual AuditOrganisationTotal AuditOrganisationTotalsAuditOrganisationTotal { get; set; }
    }
}
