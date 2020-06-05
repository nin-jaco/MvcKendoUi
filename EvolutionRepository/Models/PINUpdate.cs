using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class PINUpdate
    {
        public PINUpdate()
        {
            this.PINUpdatesCardData = new List<CardData>();
        }

        public int PINUpdateID { get; set; }
        public string PINUpateDescription { get; set; }
        public virtual ICollection<CardData> PINUpdatesCardData { get; set; }
    }
}
