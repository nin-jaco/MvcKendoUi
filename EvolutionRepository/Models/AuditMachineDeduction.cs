using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditMachineDeduction
    {
        public int AuditFiscalYearID { get; set; }
        public int AuditFiscalPeriodID { get; set; }
        public int AuditMachineID { get; set; }
        public int AuditOrganisationID { get; set; }
        public int AuditRevenueProfileID { get; set; }
        public string AuditRevenueProfileName { get; set; }
        public Nullable<int> DeductionTotalTypeID { get; set; }
        public string DeductionTotalTypeName { get; set; }
        public int AuditCollectionOrganisationID { get; set; }
        public int AuditCreditOrganisationID { get; set; }
        public int RatePercent { get; set; }
        public decimal Amount { get; set; }
        public virtual AuditMachineTotal AuditMachineTotalsAuditMachineTotal { get; set; }
    }
}
