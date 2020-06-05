using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolutionWeb.Controllers
{
    public class OrganisationController : EvolutionController
    {
        public ActionResult SearchOrganisation()
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "search";

            EvolutionRepository.Models.User user = new EvolutionRepository.Models.User();
            //Get Current User
            ViewBag.User = user;

            return View();
        }

        public ActionResult _SideMenuOrganisation(string OrganisationID)
        {
            int iOrganisationID;

            try
            {
                iOrganisationID = Convert.ToInt32(OrganisationID);
            }
            catch (Exception)
            {
                iOrganisationID = 0;
            }

            return View(model: iOrganisationID);
        }

        public ActionResult Organisations(int id)
        {
            ViewBag.ScreenName = "Organisation";

            if (id > 0)
            {
                ViewBag.ScreenDescription = "edit";
            }
            else
            {
                ViewBag.ScreenDescription = "create";
            }

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Addresses(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "addresses";

            //if (id > 0)
            //{
            //    ViewBag.ScreenDescription = "edit";
            //}
            //else
            //{
            //    ViewBag.ScreenDescription = "create";
            //}

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult SiteInformation(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "site information";

            //if (id > 0)
            //{
            //    ViewBag.ScreenDescription = "edit";
            //}
            //else
            //{
            //    ViewBag.ScreenDescription = "create";
            //}

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Employees(int id) 
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "employee";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Communications(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "communication";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Areas(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "area";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Departments(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "department";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult BankingDetails(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "banking details";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Splits(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "split";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Deductions(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "deduction";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult VATInvoices(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "vat invoice";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult ActiveDailyPeriods(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "active daily period";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Contacts(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "contact";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Locations(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "location";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult FiscalYears(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "fiscal year";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult ApprovedMachines(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "approved machine";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult Licenses(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "license";

            ViewBag.OrganisationID = id;

            return View();
        }

        public ActionResult LicenseTypes(int id)
        {
            ViewBag.ScreenName = "Organisation";
            ViewBag.ScreenDescription = "license type";

            ViewBag.OrganisationID = id;

            return View();
        }


    }
}
