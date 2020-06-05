using EvolutionBusinessLogic.Organisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class SplitController : ApiController
    {
        public EvolutionRepository.ManualModels.GetSplitListResult Get([FromUri]int organisationID, int skip, int take)
        {
            return SplitLogic.GetAllOrganisationSplits(organisationID, skip, take);
        }

        public HttpResponseMessage SaveRevenueProfileSplits(EvolutionRepository.ManualModels.RevenueProfileSimple simpleProfile)
        {
            bool Result = SplitLogic.SaveRevenueProfileSplits(simpleProfile);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }
    }
}
