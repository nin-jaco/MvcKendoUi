using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditFiscalPeriod
    {
        public AuditFiscalPeriod()
        {
            this.AuditFiscalPeriodsAuditMachineTotals = new List<AuditMachineTotal>();
            this.AuditFiscalPeriodsAuditOrganisationTotals = new List<AuditOrganisationTotal>();
        }

        public int AuditOrganisationID { get; set; }
        public int AuditFiscalYearID { get; set; }
        public int AuditFiscalPeriodID { get; set; }
        public string FiscalYearName { get; set; }
        public string FiscalPeriodName { get; set; }
        public Nullable<int> AuditFiscalPeriodTypeID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime DateProcessed { get; set; }
        public Nullable<System.DateTime> AuditDateProcessed { get; set; }
        public virtual AuditFiscalPeriodType AuditFiscalPeriodTypesAuditFiscalPeriodType { get; set; }
        public virtual FiscalPeriod FiscalPeriodsFiscalPeriod { get; set; }
        public virtual ICollection<AuditMachineTotal> AuditFiscalPeriodsAuditMachineTotals { get; set; }
        public virtual ICollection<AuditOrganisationTotal> AuditFiscalPeriodsAuditOrganisationTotals { get; set; }
    }
}
