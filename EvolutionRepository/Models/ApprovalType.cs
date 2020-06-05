using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ApprovalType
    {
        public ApprovalType()
        {
            this.ApprovalTypesApprovals = new List<Approval>();
        }

        public int ApprovalTypeID { get; set; }
        public string ApprovalTypeName { get; set; }
        public virtual ICollection<Approval> ApprovalTypesApprovals { get; set; }
    }
}
