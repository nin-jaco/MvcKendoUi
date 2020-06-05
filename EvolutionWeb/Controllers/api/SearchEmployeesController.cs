using EvolutionWeb.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Api_Controllers
{
    public class SearchEmployeesController : ApiController
    {
        //[AuthorizeWebAPI()]
        public EvolutionRepository.ManualModels.GetEmployeeListResult Get([FromUri] EvolutionRepository.ManualModels.SearchEmployeeParams searchParams)
        {
            var result = EvolutionBusinessLogic.Search.SearchEmployees.EmployeeList(searchParams);
            return result;

        }


    }
}
