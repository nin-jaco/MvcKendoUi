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
    public class JurisdictionsController : ApiController
    {
        [AuthorizeWebAPI()]
        public IEnumerable<EvolutionRepository.Models.Jurisdiction> GetJurisdictions([FromUri]string sessionID, [FromUri]string jurisdictionType, [FromUri]string jurisdictionValue)
        {
            List<EvolutionRepository.Models.Jurisdiction> jurisdiction = new List<EvolutionRepository.Models.Jurisdiction>();

            try
            {
                switch ((EvolutionBusinessLogic.Enumeration.JurisdictionType)Enum.Parse(typeof(EvolutionBusinessLogic.Enumeration.JurisdictionType), jurisdictionType))
                {
                    case EvolutionBusinessLogic.Enumeration.JurisdictionType.User:
                        jurisdiction = Jurisdictions.GetOrganisationJurisdictionByUser(sessionID, jurisdictionValue);
                        break;

                    case EvolutionBusinessLogic.Enumeration.JurisdictionType.All:
                        jurisdiction = Jurisdictions.GetJurisdictions();
                        break;

                    case EvolutionBusinessLogic.Enumeration.JurisdictionType.ID:
                        jurisdiction = Jurisdictions.GetJurisdictionByID(Convert.ToInt32(jurisdictionValue));
                        break;

                    case EvolutionBusinessLogic.Enumeration.JurisdictionType.Name:
                        jurisdiction = Jurisdictions.GetJurisdictionByName(jurisdictionValue);
                        break;

                    case EvolutionBusinessLogic.Enumeration.JurisdictionType.Type:
                        jurisdiction = Jurisdictions.GetJurisdictionByType(jurisdictionValue);
                        break;

                    case EvolutionBusinessLogic.Enumeration.JurisdictionType.Parent:
                        jurisdiction = Jurisdictions.GetJurisdictionByParent(Convert.ToInt32(jurisdictionValue));
                        break;

                    default:
                        throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Jurisdiction Type requested is incorrect!");
                }

                return jurisdiction;
            }
            catch(Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Not Authenticated!, Exception: " + ex.Message);
            }
        }
    }
}
