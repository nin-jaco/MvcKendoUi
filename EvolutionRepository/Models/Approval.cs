using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Approval
    {
        public Approval()
        {
            this.ApprovalsMachineApprovals = new List<MachineApproval>();
        }

        public int ApprovalID { get; set; }
        public int ApprovalTypeID { get; set; }
        public int RequestedByOrganisationID { get; set; }
        public int RequestedByEmployeeID { get; set; }
        public Nullable<int> ApprovedByOrganisationID { get; set; }
        public Nullable<int> ApprovedByEmployeeID { get; set; }
        public System.DateTime DateRequested { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public string RequestorComments { get; set; }
        public string ApproverComments { get; set; }
        public string ApprovalNumber { get; set; }
        public Nullable<int> ValidFor { get; set; }
        public Nullable<int> ApprovalStatusID { get; set; }
        public Nullable<int> SiteID { get; set; }
        public Nullable<int> MovementId { get; set; }
        public Nullable<int> InventoryItemID { get; set; }
        public virtual ApprovalStatus ApprovalStatusesApprovalStatus { get; set; }
        public virtual ApprovalType ApprovalTypesApprovalType { get; set; }
        public virtual ICollection<MachineApproval> ApprovalsMachineApprovals { get; set; }
    }
}
