using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionRepository.Models;
using EvolutionBusinessLogic.Organisations;

namespace EvolutionWeb.Controllers.api
{
    public class AreaController : ApiController
    {
        public EvolutionRepository.ManualModels.GetAreaListResult Get([FromUri]int organisationID, int skip, int take)
        {
            return AreaLogic.GetAllAreasForOrganisation(organisationID, skip, take);
        }

        public IEnumerable<EvolutionRepository.Models.Employee> GetManagersForAnOrganisation(int id)
        {
            return EvolutionBusinessLogic.LookupData.EmployeesForOrganisation.GetEmployeesForOrganisation(id);
        }

        public Area Get(int id)
        {
            return AreaLogic.GetAreaByID(id);
        }

        public HttpResponseMessage Insert([FromBody] Area area)
        {

            bool Result = AreaLogic.AddArea(area);

            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

        }

        public HttpResponseMessage Update([FromBody] Area area)
        {

            bool Result = AreaLogic.UpdateArea(area);

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

            bool Result = AreaLogic.DeleteArea(id);

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
