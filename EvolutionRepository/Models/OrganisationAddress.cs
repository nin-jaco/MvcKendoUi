using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationAddress
    {
        public int OrganisationID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public virtual Address AddressesAddress { get; set; }
        public virtual AddressType AddressTypesAddressType { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
