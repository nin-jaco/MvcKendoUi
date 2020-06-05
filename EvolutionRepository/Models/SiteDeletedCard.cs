using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class SiteDeletedCard
    {
        public int SiteID { get; set; }
        public int CardID { get; set; }
        public System.DateTime DateDeleted { get; set; }
        public Nullable<int> InstructionID { get; set; }
    }
}
