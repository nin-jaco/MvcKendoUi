using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditOrganisationInvoice
    {
        public int AuditOrganisationID { get; set; }
        public int AuditFiscalYearID { get; set; }
        public int AuditFiscalPeriodID { get; set; }
        public string FiscalYearName { get; set; }
        public string FiscalPeriodName { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Invoice { get; set; }
    }
}
