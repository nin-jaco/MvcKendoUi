using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EvolutionBusinessLogic.Account;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionWeb.Controllers
{
    [Authorize]
    public class AccountController : EvolutionController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RegisterModel model)
        {
            return View(model);
        }

        public ActionResult Edit(string Username)
        {
            User user = EvolutionBusinessLogic.Account.UserManager.LoadUserByUsername(Username);

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User model)
        {
            return View(model);
        }

        public ActionResult ChangePassword(string Username)
        {
            User user = EvolutionBusinessLogic.Account.UserManager.LoadUserByUsername(Username);

            return View(user);
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            return RedirectToAction("ChangePasswordSuccess");
        }

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        public ActionResult Details(string Username)
        {
            User user = EvolutionBusinessLogic.Account.UserManager.LoadUserByUsername(Username);

            return View(user);
        }

        public ActionResult Delete(string Username)
        {
            User user = EvolutionBusinessLogic.Account.UserManager.LoadUserByUsername(Username);

            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(string id, FormCollection formData)
        {
            return RedirectToAction("DeleteConfirmed");
        }

        public ActionResult DeleteConfirmed()
        {
            return View();
        }

        //public ActionResult Roles()
        //{
        //    ICollection<Role> roles = EvolutionBusinessLogic.Account.RoleManager.LoadAllRoles();

        //    return View(roles);
        //}

        public ActionResult DeleteRole(string roleName)
        {
            try
            {
                //EvolutionBusinessLogic.Account.RoleManager.DeleteRole(roleName);

                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        //public ActionResult UserRoles(string roleName)
        //{
        //    ICollection<Role> roles = EvolutionBusinessLogic.Account.RoleManager.LoadUserRoles(roleName);

        //    return View(roles);
        //}

        [HttpPost]
        public ActionResult UserRoles(string id, FormCollection formData)
        {

            return RedirectToAction("Roles");
        }

        public ActionResult CreateRole(FormCollection formData)
        {
            return RedirectToAction("Roles");
        }

    }
}
