using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineApproval
    {
        public int ApprovalID { get; set; }
        public int MachineID { get; set; }
        public virtual Approval ApprovalsApproval { get; set; }
    }
}
