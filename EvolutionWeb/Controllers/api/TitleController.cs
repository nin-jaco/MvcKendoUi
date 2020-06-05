using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class TitleController : ApiController
    {
        public IEnumerable<EvolutionRepository.Models.Title> GetTitles()
        {
            List<EvolutionRepository.Models.Title> Titles = EvolutionBusinessLogic.Employees.EmployeeBL.GetTitles();

            return Titles;
        }
    }
}
