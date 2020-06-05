using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolutionWeb.Controllers
{
    public class AdministrationController : EvolutionController
    {
        public ActionResult Users()
        {
            ViewBag.ScreenName = "Maintain Users";
            ViewBag.ScreenDescription = "Add / Update / Delete";
            
            return View();

        }

        public ActionResult Groups()
        {
            ViewBag.ScreenName = "Maintain Groups";
            ViewBag.ScreenDescription = "Add / Update / Delete";
            
            return View();
        }

        public ActionResult MasterData()
        {
            ViewBag.ScreenName = "Maintain Master Data";
            ViewBag.ScreenDescription = "Add / Update / Delete";
            
            return View();
        }

        public ActionResult RenderMasterDataAttributes(string id)
        {
            switch ((EvolutionBusinessLogic.Enumeration.MasterDataType)Enum.Parse(typeof(EvolutionBusinessLogic.Enumeration.MasterDataType), id))
            {
                case EvolutionBusinessLogic.Enumeration.MasterDataType.Areas:

                    return PartialView("~/Views/Shared/Organisation/_Areas.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.Suburbs:

                    return PartialView("~/Views/Shared/Organisation/_Suburbs.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.City:

                    return PartialView("~/Views/Shared/Organisation/_City.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.Districts:

                    return PartialView("~/Views/Shared/Organisation/_Districts.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.Banks:

                    return PartialView("~/Views/Shared/Organisation/_Banks.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.Titles:

                    return PartialView("~/Views/Shared/Organisation/_Titles.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.EmployeeStatuses:

                    return PartialView("~/Views/Shared/Organisation/_EmployeeStatuses.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.LicenseStatuses:

                    return PartialView("~/Views/Shared/Organisation/_LicenseStatuses.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.CommunicationsType:

                    return PartialView("~/Views/Shared/Organisation/_CommunicationsType.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.Jurisdictions:

                    return PartialView("~/Views/Shared/Organisation/_Jurisdictions.cshtml");

                case EvolutionBusinessLogic.Enumeration.MasterDataType.Entitytypes:

                    return PartialView("~/Views/Shared/Organisation/_Entitytypes.cshtml");

                default:

                    throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Could not find required page", "Evolution could not find the required partial page using the key.");
            }
        }

        public ActionResult AuditReports()
        {
            ViewBag.ScreenName = "Audit Reports";
            ViewBag.ScreenDescription = "View";

            return View();
        }

        public ActionResult SearchByOrganisation()
        {
            return View();
        }

        public ActionResult SearchByEmployee()
        {
            return View();
        }

        public ActionResult SearchByMachine()
        {
            return View();
        }

        #region Audits
        //public ActionResult SearchAudits()
        //{

        //    ViewBag.Title = "Search Audits";
        //    ViewBag.PageTitle = "Search Audits";

        //    ViewBag.AuditType = "AuditIdentities";

        //    return View();

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken()]
        //public ActionResult PerformSearchAudits(FormCollection collection)
        //{

        //    ViewBag.Title = "Performed Search";
        //    ViewBag.PageTitle = "Confirmation";

        //    ViewBag.AuditType = "AuditEngagements";

        //    return View();

        //}

        //public ActionResult RenderSearchAuditsAttributes(string id)
        //{
        //    ViewBag.DateFormat = IRSBusinessLogic.Utilities.Constants.GetDateFormat();
        //    ViewBag.DateTimeFormat = IRSBusinessLogic.Utilities.Constants.GetDateTimeFormat();

        //    IRSRepository.Models.ExternalIdentity usr = (IRSRepository.Models.ExternalIdentity)HttpContext.Session["UserInfo"];
        //    var usrCompany = IRSBusinessLogic.LookupData.Companies.GetCompanyByName(usr.CompanyName);

        //    switch ((IRSBusinessLogic.Enumeration.AuditType)Enum.Parse(typeof(IRSBusinessLogic.Enumeration.AuditType), id))
        //    {
        //        case IRSBusinessLogic.Enumeration.AuditType.AuditEngagements:

        //            DateTime _yearend = IRSBusinessLogic.Utilities.BasicUtils.GetCompanyYearEnd(usrCompany.CompanyKey, DateTime.Today);
        //            ViewBag.EndOfYear = _yearend.ToString(ViewBag.DateFormat);

        //            return PartialView("_AuditEngagements");

        //        case IRSBusinessLogic.Enumeration.AuditType.AuditIdentities:

        //            return PartialView("_AuditIdentities");

        //        default:

        //            throw new IRSBusinessLogic.Exceptions.IRSException("Could not find required page", "The IRS could not find the required partial page using the key.");
        //    }

        //}

        //public ActionResult DisplayAudit(string id)
        //{
        //    string[] split = id.Split('~');
        //    Guid IdentityKey = Guid.Parse(split[0]);

        //    if (split.Count() == 1)
        //    {
        //        ViewBag.EngagementInstanceKey = Guid.Empty;
        //    }
        //    else
        //    {
        //        ViewBag.EngagementInstanceKey = Guid.Parse(split[1]);
        //    }

        //    return View(IRSBusinessLogic.Search.SearchIdentity.GetIdentityByKey(IdentityKey));

        //}

        //[ChildActionOnly]
        //public ActionResult RenderAuditAttributeViewer(List<IRSRepository.ManualModels.AuditsSimple> AuditAttHolders)
        //{
        //    List<IRSRepository.Models.AuditIdentity> auditIdentities = new List<IRSRepository.Models.AuditIdentity>();
        //    List<IRSRepository.Models.AuditEngagementAttributeValueChange> auditEngagementAttributeValueChanges = new List<IRSRepository.Models.AuditEngagementAttributeValueChange>();
        //    List<IRSRepository.Models.AuditEngagementApproval> auditEngagementApprovals = new List<IRSRepository.Models.AuditEngagementApproval>();
        //    List<IRSRepository.Models.AuditEngagementStateChange> auditEngagementStateChanges = new List<IRSRepository.Models.AuditEngagementStateChange>();
        //    string AuditType = null;

        //    foreach (var auditAttHolder in AuditAttHolders)
        //    {
        //        switch ((IRSBusinessLogic.Enumeration.AuditType)Enum.Parse(typeof(IRSBusinessLogic.Enumeration.AuditType), auditAttHolder.AuditTypeName))
        //        {
        //            case IRSBusinessLogic.Enumeration.AuditType.AuditIdentities:

        //                IRSRepository.Models.AuditIdentity auditIdentity = IRSBusinessLogic.Search.SearchAuditIdentity.GetAuditIdentity(auditAttHolder.AuditID);
        //                auditIdentities.Add(auditIdentity);
        //                AuditType = IRSBusinessLogic.Enumeration.AuditType.AuditIdentities.ToString();
        //                break;

        //            case IRSBusinessLogic.Enumeration.AuditType.AuditEngagementAttributeValueChanges:

        //                IRSRepository.Models.AuditEngagementAttributeValueChange auditEngagementAttributeValueChange = IRSBusinessLogic.Search.SearchAuditEngagements.GetAuditEngagementAttributeValueChange(auditAttHolder.AuditID);
        //                auditEngagementAttributeValueChanges.Add(auditEngagementAttributeValueChange);
        //                AuditType = IRSBusinessLogic.Enumeration.AuditType.AuditEngagementAttributeValueChanges.ToString();
        //                break;

        //            case IRSBusinessLogic.Enumeration.AuditType.AuditEngagementApprovals:

        //                IRSRepository.Models.AuditEngagementApproval auditEngagementApproval = IRSBusinessLogic.Search.SearchAuditEngagements.GetAuditEngagementApproval(auditAttHolder.AuditID);
        //                auditEngagementApprovals.Add(auditEngagementApproval);
        //                AuditType = IRSBusinessLogic.Enumeration.AuditType.AuditEngagementApprovals.ToString();
        //                break;

        //            case IRSBusinessLogic.Enumeration.AuditType.AuditEngagementStateChanges:

        //                IRSRepository.Models.AuditEngagementStateChange auditEngagementStateChange = IRSBusinessLogic.Search.SearchAuditEngagements.GetAuditEngagementStateChange(auditAttHolder.AuditID);
        //                auditEngagementStateChanges.Add(auditEngagementStateChange);
        //                AuditType = IRSBusinessLogic.Enumeration.AuditType.AuditEngagementStateChanges.ToString();
        //                break;

        //            default:
        //                throw new IRSBusinessLogic.Exceptions.IRSException("IRS Exception", "IRS could not display the Audit report correctly.");
        //        }

        //    }

        //    switch ((IRSBusinessLogic.Enumeration.AuditType)Enum.Parse(typeof(IRSBusinessLogic.Enumeration.AuditType), AuditType))
        //    {
        //        case IRSBusinessLogic.Enumeration.AuditType.AuditIdentities:

        //            return PartialView("displayAuditIdentity", auditIdentities);

        //        case IRSBusinessLogic.Enumeration.AuditType.AuditEngagementAttributeValueChanges:

        //            return PartialView("displayAuditEngagementAttributeValue", auditEngagementAttributeValueChanges);

        //        case IRSBusinessLogic.Enumeration.AuditType.AuditEngagementApprovals:

        //            return PartialView("displayAuditEngagementApproval", auditEngagementApprovals);

        //        case IRSBusinessLogic.Enumeration.AuditType.AuditEngagementStateChanges:

        //            return PartialView("displayAuditEngagementState", auditEngagementStateChanges);

        //        default:
        //            throw new IRSBusinessLogic.Exceptions.IRSException("IRS Exception", "IRS could not display the Audit report correctly.");
        //    }

        //}
        #endregion
    }
}