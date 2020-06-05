using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditFiscalPeriodType
    {
        public AuditFiscalPeriodType()
        {
            this.AuditFiscalPeriodTypesAuditFiscalPeriods = new List<AuditFiscalPeriod>();
        }

        public int AuditFiscalPeriodTypeID { get; set; }
        public string AuditFiscalPeriodTypeName { get; set; }
        public virtual ICollection<AuditFiscalPeriod> AuditFiscalPeriodTypesAuditFiscalPeriods { get; set; }
    }
}
