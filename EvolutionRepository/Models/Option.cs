using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Option
    {
        public Option()
        {
            this.OptionsOrganisationOptions = new List<OrganisationOption>();
        }

        public int ModuleID { get; set; }
        public int OptionID { get; set; }
        public string OptionName { get; set; }
        public string OptionType { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<int> OptionIntData { get; set; }
        public virtual Module ModulesModule { get; set; }
        public virtual ICollection<OrganisationOption> OptionsOrganisationOptions { get; set; }
    }
}
