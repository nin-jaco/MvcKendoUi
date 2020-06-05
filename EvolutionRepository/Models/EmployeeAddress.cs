using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EmployeeAddress
    {
        public int EmployeeID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public virtual Address AddressesAddress { get; set; }
        public virtual AddressType AddressTypesAddressType { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
    }
}
