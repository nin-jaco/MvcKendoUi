using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MovementStatu
    {
        public MovementStatu()
        {
            this.MovementStatusMovements = new List<Movement>();
        }

        public int MovementStatusID { get; set; }
        public string MovementStatusName { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public virtual ICollection<Movement> MovementStatusMovements { get; set; }
    }
}
