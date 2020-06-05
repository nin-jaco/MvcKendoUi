using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionRepository.ManualModels
{
    public class SearchEmployeeParams
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeTypeID { get; set; }
        public int OrganisationID { get; set; }
        public string sessionID { get; set; }
        public int pageSize { get; set; }
        public int page { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
    }
}
