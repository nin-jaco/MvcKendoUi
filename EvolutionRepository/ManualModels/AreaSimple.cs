using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EvolutionRepository.ManualModels
{
    public class AreaSimple
    {
        public int AreaID { get; set; }
        public int OrganisationID { get; set; }
        public string OrganisationName { get; set; }
        public string AreaName { get; set; }
        public string Telephone { get; set; }
        public string EmergencyNumber { get; set; }
        public string Mobile { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeFullname { get; set; }
    }
}
