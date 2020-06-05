using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ProcessAuditLog
    {
        public int ProcessAuditID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string SourceName { get; set; }
        public string Description { get; set; }
        public bool IsInformationOnly { get; set; }
        public string ActionRequired { get; set; }
        public Nullable<System.DateTime> ActionPerformedOn { get; set; }
        public Nullable<int> CEMSUserID { get; set; }
        public Nullable<int> ResourceID { get; set; }
        public Nullable<int> ActionID { get; set; }
    }
}
