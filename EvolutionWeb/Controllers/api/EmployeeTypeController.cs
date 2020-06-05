using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class EmployeeTypeController : ApiController
    {
        public IEnumerable<EvolutionRepository.Models.EmployeeType> GetEmployeeTypes()
        {
            List<EvolutionRepository.Models.EmployeeType> EmployeeTypes = EvolutionBusinessLogic.Employees.EmployeeBL.GetEmployeeTypes();

            return EmployeeTypes;
        }
    }
}
