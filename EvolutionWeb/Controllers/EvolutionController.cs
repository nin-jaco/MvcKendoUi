using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolutionWeb.Controllers
{
    public class EvolutionController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (object.Equals(null, Session["sessionID"]))
            {
                ViewBag.sessionID = String.Empty;
            }
            else
            {
                ViewBag.sessionID = Convert.ToString(Session["sessionID"]);
            }
        }
    }
}
