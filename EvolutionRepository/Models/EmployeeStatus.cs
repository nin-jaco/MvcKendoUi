using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EmployeeStatus
    {
        public EmployeeStatus()
        {
            this.EmployeeStatusesEmployees = new List<Employee>();
        }

        public int EmployeeStatusID { get; set; }
        public string EmployeeStatusName { get; set; }
        public virtual ICollection<Employee> EmployeeStatusesEmployees { get; set; }
    }
}
