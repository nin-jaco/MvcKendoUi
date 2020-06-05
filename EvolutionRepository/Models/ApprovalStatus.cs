using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            this.ApprovalStatusesApprovals = new List<Approval>();
        }

        public int ApprovalStatusID { get; set; }
        public string ApprovalStatusName { get; set; }
        public virtual ICollection<Approval> ApprovalStatusesApprovals { get; set; }
    }
}
