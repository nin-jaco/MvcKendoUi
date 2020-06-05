using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Movement
    {
        public Movement()
        {
            this.MovementsMachineMovements = new List<MachineMovement>();
        }

        public int MovementID { get; set; }
        public Nullable<int> MovementTypeID { get; set; }
        public Nullable<int> MovementStatusID { get; set; }
        public Nullable<int> ServiceCallID { get; set; }
        public Nullable<int> RequestorID { get; set; }
        public string RequestorComments { get; set; }
        public Nullable<System.DateTime> DateRequested { get; set; }
        public Nullable<System.DateTime> DueInstallationDate { get; set; }
        public string ApprovalNumber { get; set; }
        public Nullable<int> ApproverID { get; set; }
        public string ApproverComments { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public Nullable<int> OwnerID { get; set; }
        public Nullable<int> ManagedByID { get; set; }
        public byte[] Timestamp { get; set; }
        public virtual ICollection<MachineMovement> MovementsMachineMovements { get; set; }
        public virtual MovementStatu MovementStatusMovementStatu { get; set; }
        public virtual MovementType MovementTypesMovementType { get; set; }
    }
}
