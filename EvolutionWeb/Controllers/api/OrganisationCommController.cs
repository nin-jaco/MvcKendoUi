using EvolutionBusinessLogic.Organisations;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class OrganisationCommController : ApiController
    {
        public EvolutionRepository.ManualModels.GetOrganisationCommListResult Get([FromUri]int organisationID, int skip, int take)
        {
            return OrganisationCommLogic.GetAllOrganisationCommsByID(organisationID, skip, take);
        }

        public EvolutionRepository.Models.OrganisationComm Get(int id)
        {
            return OrganisationCommLogic.GetOrganisationCommByID(id);
        }

        public HttpResponseMessage Insert([FromBody] OrganisationComm orgCom)
        {

            bool Result = OrganisationCommLogic.InsertOrganisationComm(orgCom);

            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

        }

        public HttpResponseMessage Update([FromBody] OrganisationComm orgCom)
        {

            bool Result = OrganisationCommLogic.EditOrganisationComm(orgCom);

            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

        }

        public HttpResponseMessage Delete([FromUri] int id)
        {
            var test = id;

            bool Result = OrganisationCommLogic.DeleteOrganisationComm(id);

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