using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CEMSUtilLog
    {
        public int CEMSUtilLogID { get; set; }
        public int EmployeeID { get; set; }
        public int CEMSUtilLogActionID { get; set; }
        public System.DateTime Date { get; set; }
        public string FunctionalArea { get; set; }
        public string Description { get; set; }
    }
}
