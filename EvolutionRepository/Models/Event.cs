using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Event
    {
        public int EventID { get; set; }
        public Nullable<int> SiteID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<int> ServiceCallID { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string Notes { get; set; }
        public string Notes1 { get; set; }
        public string Notes2 { get; set; }
        public string Notes3 { get; set; }
        public bool Alert { get; set; }
        public Nullable<int> EventTypeID { get; set; }
        public Nullable<int> CertifiedModelID { get; set; }
        public virtual EventType EventTypesEventType { get; set; }
    }
}
