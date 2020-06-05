using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionBusinessLogic.LookupData;
using EvolutionRepository.Models;
using EvolutionWeb.Filters;
using Newtonsoft.Json.Linq;

namespace EvolutionWeb.Controllers.api
{
    public class OrganisationTypesController : ApiController
    {
        [AuthorizeWebAPI()]
        public IEnumerable<EvolutionRepository.ManualModels.OrganisationTypeSimple> GetOrganisationTypes([FromUri] EvolutionRepository.ManualModels.GetLookupsParams getLookupsParams)
        {
            List<EvolutionRepository.ManualModels.OrganisationTypeSimple> organisationTypeSimple = new List<EvolutionRepository.ManualModels.OrganisationTypeSimple>();

            try
            {
                switch ((EvolutionBusinessLogic.Enumeration.OrganisationType)Enum.Parse(typeof(EvolutionBusinessLogic.Enumeration.OrganisationType), getLookupsParams.paramtype))
                {
                    case EvolutionBusinessLogic.Enumeration.OrganisationType.Type:
                        organisationTypeSimple = OrganisationTypes.GetOrganisationType();
                        break;

                    case EvolutionBusinessLogic.Enumeration.OrganisationType.SubType:
                        if (Convert.ToInt32(getLookupsParams.value) > 0)
                        {
                            organisationTypeSimple = OrganisationTypes.GetOrganisationSubTypeByTypeID(Convert.ToInt32(getLookupsParams.value));
                        }
                        else
                        {
                            organisationTypeSimple = OrganisationTypes.GetOrganisationSubType();
                        }
                        break;

                    default:
                        throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Jurisdiction Type requested is incorrect!");
                }

                return organisationTypeSimple;
            }
            catch(Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Not Authenticated!, Exception: " + ex.Message);
            }
        }
    }
}
