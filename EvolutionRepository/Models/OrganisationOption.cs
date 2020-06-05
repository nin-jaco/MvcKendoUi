using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationOption
    {
        public int OrganisationID { get; set; }
        public int ModuleID { get; set; }
        public int OptionID { get; set; }
        public string Value { get; set; }
        public virtual Option OptionsOption { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
