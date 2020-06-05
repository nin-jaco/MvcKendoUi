using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class FiscalPeriod
    {
        public FiscalPeriod()
        {
            this.FiscalPeriodsMachineTotals = new List<MachineTotal>();
            this.FiscalPeriodsOrganisationDeductions = new List<OrganisationDeduction>();
            this.FiscalPeriodsOrganisationTotals = new List<OrganisationTotal>();
        }

        public int FiscalYearID { get; set; }
        public int FiscalPeriodID { get; set; }
        public string FiscalPeriodName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<System.DateTime> DateProcessed { get; set; }
        public virtual AuditFiscalPeriod FiscalPeriodsAuditFiscalPeriod { get; set; }
        public virtual FiscalYear FiscalYearsFiscalYear { get; set; }
        public virtual ICollection<MachineTotal> FiscalPeriodsMachineTotals { get; set; }
        public virtual ICollection<OrganisationDeduction> FiscalPeriodsOrganisationDeductions { get; set; }
        public virtual ICollection<OrganisationTotal> FiscalPeriodsOrganisationTotals { get; set; }
    }
}
