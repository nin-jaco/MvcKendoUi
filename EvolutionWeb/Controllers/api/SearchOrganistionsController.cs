using EvolutionWeb.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Api_Controllers
{
    public class SearchOrganisationsController : ApiController
    {
        //[AuthorizeWebAPI()]
        public EvolutionRepository.ManualModels.SearchResult Get([FromUri] EvolutionRepository.ManualModels.SearchOrganisationsParams searchParams)
        {

            //EvolutionRepository.Models.User LoggedInUser = (EvolutionRepository.Models.User)System.Web.HttpContext.Current.Session["UserInfo"];
            //if (LoggedInUser == null)
            //{
            //    throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Not Authenticated!");
            //}

            EvolutionRepository.Models.User LoggedInUser = new EvolutionRepository.Models.User();
            var result = EvolutionBusinessLogic.Search.SearchOrganisations.SearchForOrganisations(searchParams, LoggedInUser);
            
            return result;

        }


    }
}
