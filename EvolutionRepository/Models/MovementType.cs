using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MovementType
    {
        public MovementType()
        {
            this.MovementTypesMovements = new List<Movement>();
        }

        public int MovementTypeID { get; set; }
        public string MovementTypeName { get; set; }
        public bool IsInventoryItem { get; set; }
        public bool IsSystemOnly { get; set; }
        public Nullable<int> RequestorOrganisationTypeID { get; set; }
        public Nullable<int> ApproverOrganisationTypeID { get; set; }
        public virtual ICollection<Movement> MovementTypesMovements { get; set; }
    }
}
