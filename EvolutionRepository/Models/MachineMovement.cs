using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineMovement
    {
        public int MovementID { get; set; }
        public int MovementLegID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<int> InventoryItemID { get; set; }
        public Nullable<int> FromSiteID { get; set; }
        public Nullable<System.DateTime> FromSiteArrivalTime { get; set; }
        public Nullable<System.DateTime> FromSiteDepartureTime { get; set; }
        public int ToSiteID { get; set; }
        public Nullable<System.DateTime> ToSiteArrivalTime { get; set; }
        public Nullable<System.DateTime> ToSiteDepartureTime { get; set; }
        public Nullable<int> RevenueProfileID { get; set; }
        public Nullable<int> CertifiedModelID { get; set; }
        public virtual Movement MovementsMovement { get; set; }
    }
}
