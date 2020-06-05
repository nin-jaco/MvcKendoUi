using EvolutionDataAccess.Organisation;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.LookupData
{
    public class EmployeesForOrganisation
    {
        public static List<Employee> GetEmployeesForOrganisation(int organisationID)
        {
            return AreaDAL.GetManagersForAnOrganisation(organisationID);
        }
    }
}
