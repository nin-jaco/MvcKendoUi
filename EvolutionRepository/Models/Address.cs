using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Address
    {
        public Address()
        {
            this.AddressesEmployeeAddresses = new List<EmployeeAddress>();
            this.AddressesOrganisationAddresses = new List<OrganisationAddress>();
        }

        public int AddressID { get; set; }
        public int JurisdictionID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public virtual ICollection<EmployeeAddress> AddressesEmployeeAddresses { get; set; }
        public virtual ICollection<OrganisationAddress> AddressesOrganisationAddresses { get; set; }
    }
}
