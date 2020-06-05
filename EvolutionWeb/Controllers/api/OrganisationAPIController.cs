using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionRepository.ManualModels;
//using EvolutionRepository.GridsData;
using EvolutionBusinessLogic.Organisations;
using EvolutionRepository.Models;

namespace EvolutionWeb.Controllers.api
{
    public class OrganisationAPIController : ApiController
    {
        // GET api/Organisation
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Organisation/5
        public string Get(int id)
        {
            return "value";
        }


        public Organisation GetOrganisation(int OrgID)
        {
            return OrganisationLogic.GetOrganisation(OrgID);
        }

        // GET api/Organisation
        public GetOrganistionListResult GetOrganisations([FromUri]int skip, int take)//OrganisationBusinessLogic.GetOrganistionListResult GetOrganisations([FromUri]int skip, int take)
        {
            return OrganisationLogic.GetOrganisations(skip, take);
          
        }


        public IEnumerable<EvolutionRepository.Models.OrganisationType> PostOrgTypes() //string GetOrgTypes()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetOrgTypes();          
        }

        public IEnumerable<EvolutionRepository.Models.OrganisationSubType> PostOrgSubtypes() //string GetOrgSubtypes()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetOrgSubTypes();
         
        }

       
        public IEnumerable<EvolutionRepository.Models.Organisation> PostOrgParent()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetParentOrgs();
        }

        public IEnumerable<EvolutionRepository.Models.Jurisdiction> PostOrgJurisdiction()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetJurisdictions();
            
        }

        public string GetBankAccounts()
        {
            List<EvolutionRepository.Models.BankAccount> lstBK = new List<EvolutionRepository.Models.BankAccount>();
            lstBK = EvolutionBusinessLogic.Organisations.OrganisationLogic.GetBankAccounts();
            var lst = new List<EvolutionRepository.Models.BankAccount>();
            foreach (var v in lstBK)
            {
                EvolutionRepository.Models.BankAccount acc = new BankAccount();
                acc.AccountNumber = v.AccountNumber;
                lst.Add(acc);
            }
            string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lst);
            return json; 
        }

        //post organisation statuses
        public IEnumerable<EvolutionRepository.Models.OrganisationStatu> PostOrganisationStatuses()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetOrgStatuses();
           
        }

        // POST api/Organisation
        public HttpResponseMessage PostOrganisation([FromBody]Organisation Organisation)
        {
            //OrganisationMethods Org = new OrganisationMethods();
            //bool Result = Org.CreateOrganisation(Organisation);
            bool Result = OrganisationLogic.CreateOrganisation(Organisation);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

        // PUT api/Organisation/5
        public HttpResponseMessage PutOrganisation([FromBody]Organisation Organisation)
        {
            //OrganisationMethods Org = new OrganisationMethods();
            //bool Result = Org.UpdateOrganisation(Organisation);
            bool Result = OrganisationLogic.UpdateOrganisation(Organisation);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

        // DELETE api/Organisation/5
        public HttpResponseMessage DeleteOrganisation(int id)
        {
            //OrganisationMethods Org = new OrganisationMethods();
            //bool Result = Org.DeleteOrganisation(id);
            bool Result = OrganisationLogic.DeleteOrganisation(id);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }


        public IEnumerable<EvolutionRepository.Models.Bank> PostGetBanks()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetBanks();
        }

        public IEnumerable<EvolutionRepository.Models.AccountType> PostGetBankAccountTypes()
        {
            return EvolutionBusinessLogic.Organisations.OrganisationLogic.GetBankAccountTypes();
        }

        public HttpResponseMessage PostOrgBankDetails([FromBody]BankAccount bankDetails)
        {
            bool Result = OrganisationLogic.SaveOrganisationBankDetails(bankDetails);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }           
        }


        //organisation deductions
        public HttpResponseMessage  PostSaveRevenueProfile(EvolutionRepository.Models.RevenueProfile revProfile)
        {
            bool Result = OrganisationLogic.SaveRevenueProfile(revProfile);

            if (Result==false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest); //EvolutionDataAccess.Organisation.OrganisationDAL.SaveRevenueProfile(revProfile);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }


        public EvolutionRepository.ManualModels.GetRevenueProfileResult GetOrgRevenueProfile(int OrganisationID, int skip, int take)
        {
            var Result = OrganisationLogic.GetOrgRevenueProfile(OrganisationID,skip,take);
            return Result;          
        }

        [HttpDelete]
        public HttpResponseMessage DeleteOrgRevenueProfile(int id)
        {
            bool Result = OrganisationLogic.DeleteOrganisationRevenueProfile(id);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest); //EvolutionDataAccess.Organisation.OrganisationDAL.SaveRevenueProfile(revProfile);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

        public List<EvolutionRepository.Models.RevenueProfileType> PostGetRevenueProfileType()
        {
            return OrganisationLogic.GetRevenueProfileType();            
        }

        public List<EvolutionRepository.Models.DeductionType> PostGetDeductionType()
        {
            return OrganisationLogic.GetDeductionType();            
        }

        public List<EvolutionRepository.Models.DeductionTotalType> PostGetDeductionTotalType()
        {
            return OrganisationLogic.GetDeductionTotalType();            
        }


        //revenue profile scales
        public EvolutionRepository.ManualModels.GetRevenueProfileScaleResult GetRevenueProfileScales(int revenueProfileID, int skip, int take)
        {
            return OrganisationLogic.GetRevenueProfileScales(revenueProfileID);
        }


        public HttpResponseMessage SaveRevenueProfileScale(EvolutionRepository.Models.RevenueScale revScale)
        {
            bool Result = OrganisationLogic.SaveRevenueProfileScale(revScale);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest); //EvolutionDataAccess.Organisation.OrganisationDAL.SaveRevenueProfile(revProfile);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

        public HttpResponseMessage DeleteRevenueProfileScale(EvolutionRepository.ManualModels.RevenueProfileScaleKeys revKeys)
        {
            bool Result = OrganisationLogic.DeleteRevenueProfileScale(revKeys);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest); //EvolutionDataAccess.Organisation.OrganisationDAL.SaveRevenueProfile(revProfile);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }


    }
}
