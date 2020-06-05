using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditDailyDeduction
    {
        public int AuditMachineID { get; set; }
        public System.DateTime ApplicableDate { get; set; }
        public int RevenueProfileID { get; set; }
        public int AuditSiteID { get; set; }
        public string RevenueProfileName { get; set; }
        public int DeductionTotalTypeID { get; set; }
        public string DeductionTotalTypeName { get; set; }
        public int AuditCollectionOrganisationID { get; set; }
        public int AuditCreditOrganisationID { get; set; }
        public int RatePercent { get; set; }
        public decimal Amount { get; set; }
    }
}
