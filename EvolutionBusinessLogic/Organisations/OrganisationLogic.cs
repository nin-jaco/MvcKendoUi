using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.Models;
//using EvolutionRepository.GridsData;
using EvolutionRepository.ManualModels;

namespace EvolutionBusinessLogic.Organisations
{
    public class OrganisationLogic
    {

        public static EvolutionRepository.Models.Organisation GetOrganisation(int OrgID)
        {
            return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrganisation(OrgID);
        }

        public static GetOrganistionListResult GetOrganisations(int skip, int take)
        {
            return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrganisations(skip, take);
        }

        public static bool UpdateOrganisation(EvolutionRepository.Models.Organisation UpdateOrg)
        {
            var Result = false;

            try
            {
                EvolutionDataAccess.Organisation.OrganisationDAL.UpdateOrganisation(UpdateOrg);
                Result = true;
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }

            return Result;
        }

        public static bool CreateOrganisation(EvolutionRepository.Models.Organisation CreateOrg)
        {
            var Result = false;

            try
            {
                EvolutionDataAccess.Organisation.OrganisationDAL.CreateOrganisation(CreateOrg);
                Result = true;
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }

            return Result;
        }

        public static bool DeleteOrganisation(int Id)
        {
            var Result = false;

            try
            {
                EvolutionDataAccess.Organisation.OrganisationDAL.DeleteOrganisation(Id);
                Result = true;
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }

            return Result;
        }

        public static List<EvolutionRepository.Models.OrganisationType> GetOrgTypes()
        {
            List<EvolutionRepository.Models.OrganisationType> OrgTypesList = new List<EvolutionRepository.Models.OrganisationType>();

            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrgTypes();              
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }

            //return OrgTypesList;
        }

        public static List<EvolutionRepository.Models.OrganisationSubType> GetOrgSubTypes()
        {
            List<EvolutionRepository.Models.OrganisationSubType> OrgSubTypesList = new List<EvolutionRepository.Models.OrganisationSubType>();

            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrgSubTypes();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }

            //return OrgSubTypesList;
        }

        public static List<EvolutionRepository.Models.Organisation> GetParentOrgs()
        {
            List<EvolutionRepository.Models.Organisation> orgs = new List<EvolutionRepository.Models.Organisation>();

            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetParentOrgs();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }

            //return orgs;
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictions()
        {
            List<EvolutionRepository.Models.Jurisdiction> jurisdictions = new List<EvolutionRepository.Models.Jurisdiction>();
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetJurisdictions();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static List<EvolutionRepository.Models.BankAccount> GetBankAccounts()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetBankAccounts();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static List<EvolutionRepository.Models.OrganisationStatu> GetOrgStatuses()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrgStatuses();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static EvolutionRepository.Models.BankAccount GetOrganisationBankDetails(int OrganisationId)
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrganisationBankingDetails(OrganisationId);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static bool SaveOrganisationBankDetails(EvolutionRepository.Models.BankAccount bankAcc)
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.SaveBankingDetails(bankAcc);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }


        public static List<EvolutionRepository.Models.Bank> GetBanks()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetBanks();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static List<EvolutionRepository.Models.AccountType> GetBankAccountTypes()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetBankAccountTypes();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }


        //organisation deductions
        public static bool SaveRevenueProfile(EvolutionRepository.Models.RevenueProfile revProfile)
        {
            bool Result = false;

            try
            {
                revProfile.DateAdded = DateTime.Now;
                EvolutionDataAccess.Organisation.OrganisationDAL.SaveRevenueProfile(revProfile);
                Result = true;
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }

            return Result;
        }

        public static bool DeleteOrganisationRevenueProfile(int organisationID)
        {
            bool Result = false;
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.DeleteOrganisationRevenueProfile(organisationID);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
            return Result;
        }

        public static EvolutionRepository.ManualModels.GetRevenueProfileResult GetOrgRevenueProfile(int OrganisationID, int skip, int take)
        {
            try
            {
               return EvolutionDataAccess.Organisation.OrganisationDAL.GetOrgRevenueProfile(OrganisationID, skip, take);
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static List<EvolutionRepository.Models.RevenueProfileType> GetRevenueProfileType()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetRevenueProfileType();               
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static List<EvolutionRepository.Models.DeductionType> GetDeductionType()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetDeductionType();                
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static List<EvolutionRepository.Models.DeductionTotalType> GetDeductionTotalType()
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetDeductionTotalType();               
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }

        public static EvolutionRepository.ManualModels.GetRevenueProfileScaleResult GetRevenueProfileScales(int revenueProfileID)
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.GetRevenueProfileScales(revenueProfileID);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }            
        }

        public static bool SaveRevenueProfileScale(EvolutionRepository.Models.RevenueScale revScale)
        {
            revScale.DateAdded = DateTime.Now;
            return EvolutionDataAccess.Organisation.OrganisationDAL.SaveRevenueProfileScale(revScale);
        }

        public static bool DeleteRevenueProfileScale(EvolutionRepository.ManualModels.RevenueProfileScaleKeys keys)
        {
            try
            {
                return EvolutionDataAccess.Organisation.OrganisationDAL.DeleteRevenueProfileScale(keys);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }
        }
    }
}
