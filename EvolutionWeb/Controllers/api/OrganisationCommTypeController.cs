using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionBusinessLogic;

namespace EvolutionWeb.Controllers.api
{
    public class OrganisationCommTypeController : ApiController
    {
        public IEnumerable<EvolutionRepository.Models.OrganisationCommType> GetListOfOrganisationCommTypes()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationCommTypeLogic.GetAllOrganisationCommTypes();
        }
    }
}
