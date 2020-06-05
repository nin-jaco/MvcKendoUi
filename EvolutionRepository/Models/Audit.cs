using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Audit
    {
        public long AuditID { get; set; }
        public string AuditType { get; set; }
        public System.DateTime AuditDate { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string IPAddress { get; set; }
        public string UserAgentString { get; set; }
        public string ChangeByUserID { get; set; }
        public string ChangeByFullName { get; set; }
    }
}
