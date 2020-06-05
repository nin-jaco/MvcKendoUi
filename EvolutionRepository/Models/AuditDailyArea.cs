using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditDailyArea
    {
        public System.DateTime ApplicableDate { get; set; }
        public int OrganisationID { get; set; }
        public int AreaID { get; set; }
        public int AreaManagerID { get; set; }
        public int AccountManagerID { get; set; }
        public int MachineID { get; set; }
        public int ModelID { get; set; }
    }
}
