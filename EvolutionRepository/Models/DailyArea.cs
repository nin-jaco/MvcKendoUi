using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class DailyArea
    {
        public System.DateTime ApplicableDate { get; set; }
        public int OrganisationID { get; set; }
        public int AreaID { get; set; }
        public int AreaManagerID { get; set; }
        public int AccountManagerID { get; set; }
        public int MachineID { get; set; }
        public int ModelID { get; set; }
        public virtual Area AreasArea { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
        public virtual Employee Employees1Employee { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
