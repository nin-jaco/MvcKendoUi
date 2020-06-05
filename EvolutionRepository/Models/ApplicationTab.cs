using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ApplicationTab
    {
        public int ApplicationTabID { get; set; }
        public string ApplicationTabName { get; set; }
        public string TabKey { get; set; }
        public string TabIcon { get; set; }
        public Nullable<int> SortOrder { get; set; }
    }
}
