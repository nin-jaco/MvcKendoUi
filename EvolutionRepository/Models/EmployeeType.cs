using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            this.EmployeeTypeEmployees = new List<Employee>();
            this.EmployeeTypesEmployeeTypeCardTypes = new List<EmployeeTypeCardType>();
            this.OrganisationEmployeeTypesOrganisationTypes = new List<OrganisationType>();
        }

        public int EmployeeTypeID { get; set; }
        public string EmployeeTypeName { get; set; }
        public bool IsCalloutEngineer { get; set; }
        public bool IsServiceEngineer { get; set; }
        public bool IsManager { get; set; }
        public virtual ICollection<Employee> EmployeeTypeEmployees { get; set; }
        public virtual ICollection<EmployeeTypeCardType> EmployeeTypesEmployeeTypeCardTypes { get; set; }
        public virtual ICollection<OrganisationType> OrganisationEmployeeTypesOrganisationTypes { get; set; }
    }
}
