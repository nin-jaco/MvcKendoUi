using EvolutionBusinessLogic.Organisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class DepartmentController : ApiController
    {
        public EvolutionRepository.ManualModels.GetDepartmentListResult Get([FromUri]int organisationID, int skip, int take)
        {
            return DepartmentLogic.GetAllDepartmentsByID(organisationID, skip, take);
        }
    }
}
