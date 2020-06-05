using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class RepairStatus
    {
        public RepairStatus()
        {
            this.RepairStatusesServiceCalls = new List<ServiceCall>();
        }

        public int RepairStatusID { get; set; }
        public string RepairStatusName { get; set; }
        public virtual ICollection<ServiceCall> RepairStatusesServiceCalls { get; set; }
    }
}
