using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class LifeCycleStatu
    {
        public int LifeCycleStatusId { get; set; }
        public string LifeCycleStatusName { get; set; }
        public bool IsVisible { get; set; }
    }
}
