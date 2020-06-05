using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionRepository.ManualModels
{
    public class OrganisationCommSimple
    {
        public int OrganisationCommID { get; set; }
        public int OrganisationID { get; set; }
        public string OrganisationName { get; set; }
        public int OrganisationCommTypeID { get; set; }
        public string OrganisationCommTypeName { get; set; }
        public string Address { get; set; }
        public string AddressPrefix { get; set; }
    }
}
