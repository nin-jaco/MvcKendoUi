using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolutionWeb.Controllers
{
    public class EmployeeController : EvolutionController
    {
        public ActionResult SearchEmployee()
        {
            ViewBag.ScreenName = "Employee";
            ViewBag.ScreenDescription = "search";

            return View();
        }

        public ActionResult CreateOrEdit()
        {
            ViewBag.ScreenName = "Employee";
            ViewBag.ScreenDescription = "create or edit";

            return View();   
        }

        public ActionResult RenderEmployeeAttributes(string id)
        {
            switch ((EvolutionBusinessLogic.Enumeration.EmployeeDataType)Enum.Parse(typeof(EvolutionBusinessLogic.Enumeration.EmployeeDataType), id))
            {
                case EvolutionBusinessLogic.Enumeration.EmployeeDataType.Employees:

                    return PartialView("~/Views/Shared/Employee/_Employees.cshtml");

                case EvolutionBusinessLogic.Enumeration.EmployeeDataType.Licenses:

                    return PartialView("~/Views/Shared/Employee/_Licenses.cshtml");

                default:

                    throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Could not find required page", "Evolution could not find the required partial page using the key.");
            }

        }
    }
}
