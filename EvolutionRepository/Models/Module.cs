using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Module
    {
        public Module()
        {
            this.ModulesOptions = new List<Option>();
            this.OrganisationTypeModulesOrganisationTypes = new List<OrganisationType>();
        }

        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public Nullable<bool> IsSystem { get; set; }
        public virtual ICollection<Option> ModulesOptions { get; set; }
        public virtual ICollection<OrganisationType> OrganisationTypeModulesOrganisationTypes { get; set; }
    }
}
