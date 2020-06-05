using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            this.AddressTypesEmployeeAddresses = new List<EmployeeAddress>();
            this.AddressTypesOrganisationAddresses = new List<OrganisationAddress>();
        }

        public int AddressTypeID { get; set; }
        public string AddressTypeName { get; set; }
        public virtual ICollection<EmployeeAddress> AddressTypesEmployeeAddresses { get; set; }
        public virtual ICollection<OrganisationAddress> AddressTypesOrganisationAddresses { get; set; }
    }
}
