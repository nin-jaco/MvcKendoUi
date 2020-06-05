using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionBusinessLogic;

namespace EvolutionWeb.Controllers.api
{
    public class OrganisationTreeController : ApiController
    {
        public IEnumerable<EvolutionRepository.Models.OrgTree> GetOrgTree([FromUri]string sessionID)
        {
            return EvolutionBusinessLogic.OrgTree.OrgTreeLogic.GetOrgTree(sessionID);
        }
    }
}
