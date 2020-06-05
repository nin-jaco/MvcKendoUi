using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using EvolutionBusinessLogic.Account;
using EvolutionBusinessLogic.Authentication;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionWeb.Controllers
{
    public class AuthenticationController : EvolutionController
    {
        public ActionResult LogOn()
        {
            ViewBag.ScreenName = "Evolution";
            ViewBag.ScreenDescription = "logon";

            EvolutionRepository.Models.User user = new EvolutionRepository.Models.User();

            //Get Current User
            ViewBag.User = user;

            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model)
        {
            try
            {
                string sessionID = Authenticate.ValidateUser(model);
                if (!String.IsNullOrEmpty(sessionID))
                {
                    Session["sessionID"] = sessionID;
                    //EvolutionDBContext = sessionID;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    model.LogOnResult = "The user name or password provided is incorrect.";
                }
            }
            catch (Exception ex)
            {
                model.LogOnResult = ex.Message;
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult LogOff()
        {
            //FormsAuthentication.SignOut();

            return RedirectToAction("LogOn", "Authentication");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            // Attempt to register the user
            if (Authenticate.RegisterUser(model))
            {
                //FormsAuthentication.SetAuthCookie(model.Username, false /* createPersistentCookie */);
                return RedirectToAction("Index", "Account");
            }
            else
            {
                model.RegisterResult = "The user name or password provided is incorrect.";
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            // ChangePassword will throw an exception rather
            // than return false in certain failure scenarios.
            bool changePasswordSucceeded = false;

            try
            {
                User currentUser = EvolutionBusinessLogic.Account.UserManager.LoadUserByUsername(model.Username);
                changePasswordSucceeded = Authenticate.ChangePassword(model);
            }
            catch (Exception)
            {
                changePasswordSucceeded = false;
            }

            if (changePasswordSucceeded)
            {
                return RedirectToAction("ChangePasswordSuccess");
            }
            else
            {
                model.ChangePasswordResult = "The current password is incorrect or the new password is invalid.";
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [Authorize]
        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }
    }
}