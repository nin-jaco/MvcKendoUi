using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class MenuController : ApiController
    {
        public String GetMenu([FromUri]string sessionID)
        {
            try
            {
                return EvolutionBusinessLogic.Resources.Resources.BuildMenu(sessionID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
