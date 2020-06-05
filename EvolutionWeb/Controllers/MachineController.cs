using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolutionWeb.Controllers
{
    public class MachineController : EvolutionController
    {
        public ActionResult MovementRequest()
        {
            return View();
        }

        public ActionResult MovementApproval()
        {
            return View();
        }

        public ActionResult CreateInventory()
        {
            return View();
        }

        public ActionResult CreateCertified()
        {
            return View();
        }

        public ActionResult CreateNew()
        {
            return View();
        }

    }
}
