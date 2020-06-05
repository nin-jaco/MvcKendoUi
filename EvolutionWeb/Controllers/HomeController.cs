using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvolutionRepository.ManualModels;

namespace EvolutionWeb.Controllers
{
    public class HomeController : EvolutionController
    {
        public ActionResult Index()
        {
            ViewBag.ScreenName = "Evolution";
            ViewBag.ScreenDescription = "central electronic monitoring system";

            return View();
        }
    }
}