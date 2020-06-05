using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Department
    {
        public Department()
        {
            this.DepartmentsEmployees = new List<Employee>();
        }

        public int DepartmentID { get; set; }
        public Nullable<int> OrganisationID { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> DepartmentParentID { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
        public virtual ICollection<Employee> DepartmentsEmployees { get; set; }
    }
}
