using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ServiceCall
    {
        public int ServiceCallID { get; set; }
        public Nullable<int> SiteID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public int ReceivedByID { get; set; }
        public Nullable<int> TargetEngineerID { get; set; }
        public Nullable<int> FixingEngineerID { get; set; }
        public string FaultDescription { get; set; }
        public Nullable<System.DateTime> CallReceiptTime { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<System.DateTime> TimeCompleted { get; set; }
        public Nullable<int> FaultID { get; set; }
        public Nullable<int> SignificantEventID { get; set; }
        public string Comments { get; set; }
        public string JobCardNumber { get; set; }
        public int RepairStatusID { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual RepairStatus RepairStatusesRepairStatus { get; set; }
    }
}
