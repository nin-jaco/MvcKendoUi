using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class FiscalPeriodType
    {
        public FiscalPeriodType()
        {
            this.FiscalPeriodTypesFiscalYears = new List<FiscalYear>();
        }

        public int FiscalPeriodTypeID { get; set; }
        public string FiscalPeriodTypeName { get; set; }
        public bool IsCalculatedAtEnd { get; set; }
        public Nullable<int> IsBasedOnPrevious { get; set; }
        public virtual ICollection<FiscalYear> FiscalPeriodTypesFiscalYears { get; set; }
    }
}
