using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class FiscalYear
    {
        public FiscalYear()
        {
            this.FiscalYearsFiscalPeriods = new List<FiscalPeriod>();
        }

        public int OrganisationID { get; set; }
        public int FiscalYearID { get; set; }
        public int FiscalPeriodTypeID { get; set; }
        public string FiscalYearName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public short FiscalPeriodDaysGrace { get; set; }
        public Nullable<System.DateTime> DateProcessed { get; set; }
        public virtual ICollection<FiscalPeriod> FiscalYearsFiscalPeriods { get; set; }
        public virtual FiscalPeriodType FiscalPeriodTypesFiscalPeriodType { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
