using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationStatu
    {
        public int OrganisationStatusID { get; set; }
        public string OrganisationStatusName { get; set; }
        public bool IsVisible { get; set; }
    }
}
