using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class EmployeeStatusController : ApiController
    {
        public IEnumerable<EvolutionRepository.Models.EmployeeStatus> GetEmployeeStatuses()
        {
            List<EvolutionRepository.Models.EmployeeStatus> EmployeeStatuses = EvolutionBusinessLogic.Employees.EmployeeBL.GetEmployeeStatuses();

            return EmployeeStatuses;
        }
    }
}
