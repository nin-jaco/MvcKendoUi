using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class UserSession
    {
        public string SessionID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<System.DateTime> SessionStarted { get; set; }
        public Nullable<int> TopOrganisationID { get; set; }
    }
}
