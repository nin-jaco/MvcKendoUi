using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EvolutionDataAccess.Organisation
{
    public class OrganisationDAL
    {
        public static EvolutionRepository.ManualModels.GetOrganistionListResult GetOrganisations(int skip, int take)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;

                var Result = new EvolutionRepository.ManualModels.GetOrganistionListResult();
                Result.count = ctx.Organisations.Count();

                Result.data = ctx.Organisations.OrderBy(x => x.OrganisationID).Skip(skip).Take(take).ToList();
                return Result;
            }
        }

        public static EvolutionRepository.Models.Organisation GetOrganisation(int OrgID)
        {
            EvolutionRepository.Models.Organisation org = new EvolutionRepository.Models.Organisation();
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                org = ctx.Database.SqlQuery<EvolutionRepository.Models.Organisation>("Evo_memGetOrganisation @OrganisationID", new SqlParameter("@OrganisationID", OrgID)).FirstOrDefault();

                return org; //ctx.Organisations.Where(o => o.OrganisationID == OrgID).FirstOrDefault();
            }
        }

        
        public static bool UpdateOrganisation(EvolutionRepository.Models.Organisation UpdateOrg)
        {
            var Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_memSaveOrganisations @OrganisationID,@OrganisationName,@CompanyNumber,@TaxNumber," +
                     "@OrganisationTypeID,@OrganisationSubTypeID,@ParentID,@MaximumMachines,@JurisdictionID,@TelephoneCode,@TelephoneNumber," + 
                     "@FaxCode,@FaxNumber,@ContactName,@EmailAddress,@WebSiteURL,@Longitude,@Latitude,@OrganisationStatusID", 
                    new SqlParameter("@OrganisationID", UpdateOrg.OrganisationID), 
                    new SqlParameter("@OrganisationName", UpdateOrg.OrganisationName),
                    new SqlParameter("@CompanyNumber", UpdateOrg.CompanyNumber),
                    new SqlParameter("@TaxNumber", UpdateOrg.TaxNumber),
                    new SqlParameter("@OrganisationTypeID", UpdateOrg.OrganisationTypeID),
                    new SqlParameter("@OrganisationSubTypeID", UpdateOrg.OrganisationSubTypeID),
                    new SqlParameter("@ParentID", UpdateOrg.ParentID),
                    new SqlParameter("@MaximumMachines", UpdateOrg.MaximumMachines),
                    new SqlParameter("@JurisdictionID", UpdateOrg.JurisdictionID),
                    new SqlParameter("@TelephoneCode", UpdateOrg.TelephoneCode),
                    new SqlParameter("@TelephoneNumber", UpdateOrg.TelephoneNumber),
                    new SqlParameter("@FaxCode", UpdateOrg.FaxCode),
                    new SqlParameter("@FaxNumber", UpdateOrg.FaxNumber),
                    new SqlParameter("@ContactName",UpdateOrg.ContactName),
                    new SqlParameter("@EmailAddress",UpdateOrg.EmailAddress),
                    new SqlParameter("@WebSiteURL", UpdateOrg.WebSiteURL),
                    new SqlParameter("@Longitude", UpdateOrg.Longitude),
                    new SqlParameter("@Latitude",UpdateOrg.Latitude),
                    //new SqlParameter("@BankAccountID",UpdateOrg.BankAccountID),
                    new SqlParameter("@OrganisationStatusID", UpdateOrg.OrganisationStatusID));

                    /*var DBOrg = ctx.Organisations.FirstOrDefault(x => x.OrganisationID == UpdateOrg.OrganisationID);
                    DBOrg = new EvolutionRepository.Models.Organisation();
                    DBOrg.BankAccountID = UpdateOrg.BankAccountID; //==null? 0 : UpdateOrg.BankAccountID;
                    DBOrg.CompanyNumber = UpdateOrg.CompanyNumber;
                    DBOrg.ContactName = UpdateOrg.ContactName;
                    DBOrg.EmailAddress = UpdateOrg.EmailAddress;
                    DBOrg.FaxCode = UpdateOrg.FaxCode;
                    DBOrg.FaxNumber = UpdateOrg.FaxNumber;
                    DBOrg.JurisdictionID = UpdateOrg.JurisdictionID;
                    DBOrg.Latitude = UpdateOrg.Latitude;
                    DBOrg.Longitude = UpdateOrg.Longitude;
                    DBOrg.MaximumMachines = UpdateOrg.MaximumMachines;
                    DBOrg.OrganisationName = UpdateOrg.OrganisationName;
                    DBOrg.OrganisationStatusID = UpdateOrg.OrganisationStatusID;
                    DBOrg.OrganisationSubTypeID = UpdateOrg.OrganisationSubTypeID;
                    DBOrg.OrganisationTypeID = UpdateOrg.OrganisationTypeID;
                    DBOrg.ParentID = UpdateOrg.ParentID;
                    DBOrg.TaxNumber = UpdateOrg.TaxNumber;
                    DBOrg.TelephoneCode = UpdateOrg.TelephoneCode;
                    DBOrg.TelephoneNumber = UpdateOrg.TelephoneNumber;
                    //DBOrg.Timestamp = System.Text.ASCIIEncoding.Unicode.GetBytes(DateTime.Now.ToString());
                    DBOrg.WebSiteURL = UpdateOrg.WebSiteURL;
                    ctx.SaveChanges();*/

                    //DBOrg.AccountManager = UpdateOrg.AccountManager;
                    //DBOrg.AssignedArea = UpdateOrg.AssignedArea;
                    //DBOrg.BusinessLicenseNo = UpdateOrg.BusinessLicenseNo;
                    //DBOrg.CashCollection = UpdateOrg.CashCollection;
                    //DBOrg.Classification = UpdateOrg.Classification;
                    //DBOrg.Collector = UpdateOrg.Collector;
                    //DBOrg.ContactPerson = UpdateOrg.ContactPerson;
                    //DBOrg.DefaultSplit = UpdateOrg.DefaultSplit;
                    //DBOrg.District = UpdateOrg.District;
                    //DBOrg.GPSCoordinates = UpdateOrg.GPSCoordinates;
                    ////DBOrg.ID = UpdateOrg.ID;
                    //DBOrg.Jurisdiction = UpdateOrg.Jurisdiction;
                    //DBOrg.LiquorLicenseNo = UpdateOrg.LiquorLicenseNo;
                    //DBOrg.MaximumMachines = UpdateOrg.MaximumMachines;
                    //DBOrg.OrgName = UpdateOrg.OrgName;
                    //DBOrg.OrgSubType = UpdateOrg.OrgSubType;
                    //DBOrg.OrgType = UpdateOrg.OrgType;
                    //DBOrg.ParentOrganisation = UpdateOrg.ParentOrganisation;
                    //DBOrg.PDI = UpdateOrg.PDI;
                    //DBOrg.PhysicalAddressCity = UpdateOrg.PhysicalAddressCity;
                    //DBOrg.PhysicalAddressPostalCode = UpdateOrg.PhysicalAddressPostalCode;
                    //DBOrg.PhysicalAddressProvince = UpdateOrg.PhysicalAddressProvince;
                    //DBOrg.PhysicalAddressStreet1 = UpdateOrg.PhysicalAddressStreet1;
                    //DBOrg.PhysicalAddressStreet2 = UpdateOrg.PhysicalAddressStreet2;
                    //DBOrg.PhysicalAddressSurburb = UpdateOrg.PhysicalAddressSurburb;
                    //DBOrg.PLAInspector = UpdateOrg.PLAInspector;
                    //DBOrg.PLAInvestigator = UpdateOrg.PLAInvestigator;
                    //DBOrg.PostalAddressCity = UpdateOrg.PostalAddressCity;
                    //DBOrg.PostalAddressPostalCode = UpdateOrg.PostalAddressPostalCode;
                    //DBOrg.PostalAddressProvince = UpdateOrg.PostalAddressProvince;
                    //DBOrg.PostalAddressStreet1 = UpdateOrg.PostalAddressStreet1;
                    //DBOrg.PostalAddressStreet2 = UpdateOrg.PostalAddressStreet2;
                    //DBOrg.PostalAddressSurburb = UpdateOrg.PostalAddressSurburb;
                    //DBOrg.RegistrationNo = UpdateOrg.RegistrationNo;
                    //DBOrg.SignedBy = UpdateOrg.SignedBy;
                    //DBOrg.SignedByDate = UpdateOrg.SignedByDate;
                    //DBOrg.SiteManager = UpdateOrg.SiteManager;
                    //DBOrg.SiteStatus = UpdateOrg.SiteStatus;
                    //DBOrg.VATVendor = UpdateOrg.VATVendor;
                    ////DBUser.Roles = UpdatedUser.Roles;
                    
                    Result = true;
                }
            }
            catch (Exception ex)
            {                
                Result = false;
                throw ex;
            }

            return Result;
        }


        public static bool CreateOrganisation(EvolutionRepository.Models.Organisation CreateOrg)
        {
            var Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    var DBOrg = ctx.Organisations.FirstOrDefault(x => x.OrganisationID == CreateOrg.OrganisationID);
                    if (DBOrg == null)
                    {
                        ctx.Database.ExecuteSqlCommand("Evo_memSaveOrganisations @OrganisationID,@OrganisationName,@CompanyNumber,@TaxNumber," +
                          "@OrganisationTypeID,@OrganisationSubTypeID,@ParentID,@MaximumMachines,@JurisdictionID,@TelephoneCode,@TelephoneNumber," +
                          "@FaxCode,@FaxNumber,@ContactName,@EmailAddress,@WebSiteURL,@Longitude,@Latitude,@OrganisationStatusID",
                         new SqlParameter("@OrganisationID", CreateOrg.OrganisationID),
                         new SqlParameter("@OrganisationName", CreateOrg.OrganisationName),
                         new SqlParameter("@CompanyNumber", CreateOrg.CompanyNumber),
                         new SqlParameter("@TaxNumber", CreateOrg.TaxNumber),
                         new SqlParameter("@OrganisationTypeID", CreateOrg.OrganisationTypeID),
                         new SqlParameter("@OrganisationSubTypeID", CreateOrg.OrganisationSubTypeID),
                         new SqlParameter("@ParentID", CreateOrg.ParentID),
                         new SqlParameter("@MaximumMachines", CreateOrg.MaximumMachines),
                         new SqlParameter("@JurisdictionID", CreateOrg.JurisdictionID),
                         new SqlParameter("@TelephoneCode", CreateOrg.TelephoneCode),
                         new SqlParameter("@TelephoneNumber", CreateOrg.TelephoneNumber),
                         new SqlParameter("@FaxCode", CreateOrg.FaxCode),
                         new SqlParameter("@FaxNumber", CreateOrg.FaxNumber),
                         new SqlParameter("@ContactName", CreateOrg.ContactName),
                         new SqlParameter("@EmailAddress", CreateOrg.EmailAddress),
                         new SqlParameter("@WebSiteURL", CreateOrg.WebSiteURL),
                         new SqlParameter("@Longitude", CreateOrg.Longitude),
                         new SqlParameter("@Latitude", CreateOrg.Latitude),
                         //new SqlParameter("@BankAccountID", CreateOrg.BankAccountID),
                         new SqlParameter("@OrganisationStatusID", CreateOrg.OrganisationStatusID));


                        /*DBOrg = new EvolutionRepository.Models.Organisation();
                        DBOrg.BankAccountID = CreateOrg.BankAccountID; // == null ? 0 : CreateOrg.BankAccountID;
                        DBOrg.CompanyNumber = CreateOrg.CompanyNumber;
                        DBOrg.ContactName = CreateOrg.ContactName;
                        DBOrg.EmailAddress = CreateOrg.EmailAddress;
                        DBOrg.FaxCode = CreateOrg.FaxCode;
                        DBOrg.FaxNumber = CreateOrg.FaxNumber;
                        DBOrg.JurisdictionID = CreateOrg.JurisdictionID;
                        DBOrg.Latitude = CreateOrg.Latitude;
                        DBOrg.Longitude = CreateOrg.Longitude;
                        DBOrg.MaximumMachines = CreateOrg.MaximumMachines;
                        DBOrg.OrganisationName = CreateOrg.OrganisationName;
                        DBOrg.OrganisationStatusID = CreateOrg.OrganisationStatusID;
                        DBOrg.OrganisationSubTypeID = CreateOrg.OrganisationSubTypeID;
                        DBOrg.OrganisationTypeID = CreateOrg.OrganisationTypeID;
                        DBOrg.ParentID = CreateOrg.ParentID;
                        DBOrg.TaxNumber = CreateOrg.TaxNumber;
                        DBOrg.TelephoneCode = CreateOrg.TelephoneCode;
                        DBOrg.TelephoneNumber = CreateOrg.TelephoneNumber;
                        //DBOrg.Timestamp = System.Text.ASCIIEncoding.Unicode.GetBytes(DateTime.Now.ToString());
                        DBOrg.WebSiteURL = CreateOrg.WebSiteURL;
                        ctx.Organisations.Add(DBOrg);
                        ctx.SaveChanges();*/


                        //DBOrg.AccountManager = CreateOrg.AccountManager;
                        //DBOrg.AssignedArea = CreateOrg.AssignedArea;
                        //DBOrg.BusinessLicenseNo = CreateOrg.BusinessLicenseNo;
                        //DBOrg.CashCollection = CreateOrg.CashCollection;
                        //DBOrg.Classification = CreateOrg.Classification;
                        //DBOrg.Collector = CreateOrg.Collector;
                        //DBOrg.ContactPerson = CreateOrg.ContactPerson;
                        //DBOrg.DefaultSplit = CreateOrg.DefaultSplit;
                        //DBOrg.District = CreateOrg.District;
                        //DBOrg.GPSCoordinates = CreateOrg.GPSCoordinates;
                        ////DBOrg.ID = UpdateOrg.ID;
                        //DBOrg.Jurisdiction = CreateOrg.Jurisdiction;
                        //DBOrg.LiquorLicenseNo = CreateOrg.LiquorLicenseNo;
                        //DBOrg.MaximumMachines = CreateOrg.MaximumMachines;
                        //DBOrg.OrgName = CreateOrg.OrgName;
                        //DBOrg.OrgSubType = CreateOrg.OrgSubType;
                        //DBOrg.OrgType = CreateOrg.OrgType;
                        //DBOrg.ParentOrganisation = CreateOrg.ParentOrganisation;
                        //DBOrg.PDI = CreateOrg.PDI;
                        //DBOrg.PhysicalAddressCity = CreateOrg.PhysicalAddressCity;
                        //DBOrg.PhysicalAddressPostalCode = CreateOrg.PhysicalAddressPostalCode;
                        //DBOrg.PhysicalAddressProvince = CreateOrg.PhysicalAddressProvince;
                        //DBOrg.PhysicalAddressStreet1 = CreateOrg.PhysicalAddressStreet1;
                        //DBOrg.PhysicalAddressStreet2 = CreateOrg.PhysicalAddressStreet2;
                        //DBOrg.PhysicalAddressSurburb = CreateOrg.PhysicalAddressSurburb;
                        //DBOrg.PLAInspector = CreateOrg.PLAInspector;
                        //DBOrg.PLAInvestigator = CreateOrg.PLAInvestigator;
                        //DBOrg.PostalAddressCity = CreateOrg.PostalAddressCity;
                        //DBOrg.PostalAddressPostalCode = CreateOrg.PostalAddressPostalCode;
                        //DBOrg.PostalAddressProvince = CreateOrg.PostalAddressProvince;
                        //DBOrg.PostalAddressStreet1 = CreateOrg.PostalAddressStreet1;
                        //DBOrg.PostalAddressStreet2 = CreateOrg.PostalAddressStreet2;
                        //DBOrg.PostalAddressSurburb = CreateOrg.PostalAddressSurburb;
                        //DBOrg.RegistrationNo = CreateOrg.RegistrationNo;
                        //DBOrg.SignedBy = CreateOrg.SignedBy;
                        //DBOrg.SignedByDate = CreateOrg.SignedByDate;
                        //DBOrg.SiteManager = CreateOrg.SiteManager;
                        //DBOrg.SiteStatus = CreateOrg.SiteStatus;
                        //DBOrg.VATVendor = CreateOrg.VATVendor;
                        ////DBUser.Roles = UpdatedUser.Roles;

                   
                    }

                    Result = true;
                }
            }
            catch (Exception ex)
            {
                Result = false;
                throw ex;
            }
            return Result;
        }


        public static bool DeleteOrganisation(int i)
        {
            var Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }


        public static List<EvolutionRepository.Models.OrganisationType> GetOrgTypes()
        {
            List<EvolutionRepository.Models.OrganisationType> OrgTypesList = new List<EvolutionRepository.Models.OrganisationType>();

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    OrgTypesList = ctx.Database.SqlQuery<EvolutionRepository.Models.OrganisationType>("Evo_memGetOrganisationTypes").ToList();
                    return OrgTypesList;
                   // return ctx.OrganisationTypes.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //return OrgTypesList;
        }

        public static List<EvolutionRepository.Models.OrganisationSubType> GetOrgSubTypes()
        {
            List<EvolutionRepository.Models.OrganisationSubType> OrgSubTypesList = new List<EvolutionRepository.Models.OrganisationSubType>();

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    OrgSubTypesList = ctx.Database.SqlQuery<EvolutionRepository.Models.OrganisationSubType>("Evo_memGetOrganisationSubTypes").ToList();
                    return OrgSubTypesList;
                    //return ctx.OrganisationSubTypes.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //return OrgSubTypesList;
        }

        public static List<EvolutionRepository.Models.Organisation> GetParentOrgs()
        {
            List<EvolutionRepository.Models.Organisation> orgs = new List<EvolutionRepository.Models.Organisation>();
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    orgs = ctx.Database.SqlQuery<EvolutionRepository.Models.Organisation>("Evo_memGetOrganisations").ToList();
                    return orgs;// return ctx.Organisations.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //return orgs;
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictions()
        {
            List<EvolutionRepository.Models.Jurisdiction> jurisdictions = new List<EvolutionRepository.Models.Jurisdiction>();
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    jurisdictions = ctx.Database.SqlQuery<EvolutionRepository.Models.Jurisdiction>("Evo_memGetJurisdictions").ToList();
                    return jurisdictions;
                    //return ctx.Jurisdictions.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<EvolutionRepository.Models.BankAccount> GetBankAccounts()
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    return ctx.BankAccounts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EvolutionRepository.Models.OrganisationStatu> GetOrgStatuses()
        {
            try
            {
                List<EvolutionRepository.Models.OrganisationStatu> orgStatuses = new List<EvolutionRepository.Models.OrganisationStatu>();
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    orgStatuses = ctx.Database.SqlQuery<EvolutionRepository.Models.OrganisationStatu>("Evo_memGetOrganisationStatuses").ToList();
                    return orgStatuses;
                    //return ctx.OrganisationStatus.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }     

        }

        public static bool AddArea(EvolutionRepository.Models.Area newArea)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {

                    var DBArea = ctx.Areas.FirstOrDefault(x => x.AreaID == newArea.AreaID);
                    if (DBArea == null)
                    {
                        DBArea = new EvolutionRepository.Models.Area();// ctx.Areas;
                        DBArea.AreaName = newArea.AreaName;
                        DBArea.Mobile = newArea.Mobile;
                        DBArea.OrganisationID = newArea.OrganisationID;
                        DBArea.Telephone = newArea.Telephone;
                        DBArea.Total_Engineers_Allocated = newArea.Total_Engineers_Allocated;
                        DBArea.Total_staff_Allocted = newArea.Total_staff_Allocted;
                        DBArea.Total_Vehicles_Allocated = newArea.Total_Vehicles_Allocated;
                        DBArea.EmployeeID = newArea.EmployeeID;
                        DBArea.EmergencyNumber = newArea.EmergencyNumber;

                        ctx.Areas.Add(DBArea);
                        ctx.SaveChanges();
                    }
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }


        public static bool DeleteArea(int areaID) //EvolutionRepository.Models.Area AddArea)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {

                    var DBArea = ctx.Areas.FirstOrDefault(x => x.AreaID == areaID);
                    if (DBArea != null)
                    {
                        ctx.Areas.Remove(DBArea);
                        ctx.SaveChanges();
                    }
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

        //--Communication

        public class GetOrganisationCommListResult
        {
            public List<EvolutionRepository.Models.OrganisationComm> data; // must contain only the record on the current page (apply the skip and take)
            public int count; // Must contain the TOTAL number of records that the user can page through
        }

        public static GetOrganisationCommListResult GetAllOrganisationCommsByID(int organisationID, int skip, int take)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;

                var Result = new GetOrganisationCommListResult();
                Result.count = ctx.Users.Count();

                Result.data = ctx.OrganisationComms.Where(p => p.OrganisationID == organisationID).OrderBy(x => x.OrganisationCommID).Skip(skip).Take(take).ToList();
                return Result;
            }
        }

        public static EvolutionRepository.Models.OrganisationComm GetOrganisationCommByID(int organisationCommID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                var result = ctx.OrganisationComms.FirstOrDefault(x => x.OrganisationCommID == organisationCommID);
                return result;
            }
        }

        public static bool EditOrganisationComm(EvolutionRepository.Models.OrganisationComm updatedOrgCom)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    var orgCom = ctx.OrganisationComms.FirstOrDefault(x => x.OrganisationCommID == updatedOrgCom.OrganisationCommID);
                    orgCom.OrganisationCommTypeID = updatedOrgCom.OrganisationCommTypeID;
                    orgCom.OrganisationID = updatedOrgCom.OrganisationID;
                    orgCom.Address = updatedOrgCom.Address;
                    orgCom.AddressPrefix = updatedOrgCom.AddressPrefix;
                    orgCom.CommsHoneymoon = updatedOrgCom.CommsHoneymoon;
                    
                    ctx.SaveChanges();

                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

        public static bool InsertOrganisationComm(EvolutionRepository.Models.OrganisationComm newOrgCom)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    var orgCom = new EvolutionRepository.Models.OrganisationComm();
                    orgCom.OrganisationCommTypeID = newOrgCom.OrganisationCommTypeID;
                    orgCom.OrganisationID = newOrgCom.OrganisationID;
                    orgCom.Address = newOrgCom.Address;
                    orgCom.AddressPrefix = newOrgCom.AddressPrefix;
                    orgCom.CommsHoneymoon = newOrgCom.CommsHoneymoon;
                    ctx.OrganisationComms.Add(orgCom);
                    ctx.SaveChanges();

                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

        public static bool DeleteOrganisationComm(int organisationCommID)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    var orgCom = ctx.OrganisationComms.FirstOrDefault(x => x.OrganisationCommID == organisationCommID);
                    ctx.OrganisationComms.Remove(orgCom);
                    ctx.SaveChanges();

                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }




        //Banking Details
        public static bool SaveBankingDetails(EvolutionRepository.Models.BankAccount bankAcc)
        {
            var Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("evo_BankAccountsSave @OrganisationID,@AccountHolder,@AccountNumber,@BankID,@Branch,@BranchCode,@AccountTypeID",
                        new SqlParameter("@OrganisationID", bankAcc.OrganisationID),
                        new SqlParameter("@AccountHolder", bankAcc.AccountHolder),
                        new SqlParameter("@AccountNumber", bankAcc.AccountNumber),
                        new SqlParameter("@BankID", bankAcc.BankID),
                        new SqlParameter("@Branch", bankAcc.Branch),
                        new SqlParameter("@BranchCode", bankAcc.BranchCode),
                        new SqlParameter("@AccountTypeID", bankAcc.AccountTypeID)
                        );
                }
                Result = true;
            }
            catch (Exception ex)
            {
                Result = false;
                throw ex;
            }
            return Result;
        }

        public static EvolutionRepository.Models.BankAccount GetOrganisationBankingDetails(int OrganisationId)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                EvolutionRepository.Models.BankAccount bankAccounts = new EvolutionRepository.Models.BankAccount();
                bankAccounts = ctx.Database.SqlQuery<EvolutionRepository.Models.BankAccount>("evo_GetOrganisationBankAccounts @OrganisationId",
                   new SqlParameter("@OrganisationID", OrganisationId)).FirstOrDefault();
                return bankAccounts;
            }
        }

        public static List<EvolutionRepository.Models.AccountType> GetBankAccountTypes()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                List<EvolutionRepository.Models.AccountType> bankAccountTypes = new List<EvolutionRepository.Models.AccountType>();
                bankAccountTypes = ctx.Database.SqlQuery<EvolutionRepository.Models.AccountType>("GetAccountTypes").ToList();
                return bankAccountTypes;
            }
        }


        public static List<EvolutionRepository.Models.Bank> GetBanks()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                List<EvolutionRepository.Models.Bank> banks = new List<EvolutionRepository.Models.Bank>();
                banks = ctx.Database.SqlQuery<EvolutionRepository.Models.Bank>("Evo_GetBanks").ToList();
                return banks;
            }
        }

        public static bool SaveRevenueProfile(EvolutionRepository.Models.RevenueProfile revProfile)
        {
            bool Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("sp_SaveRevenueProfile @RevenueProfileID,@RevenueProfileName,@OrganisationID,@DeductionTotalTypeID,"+
                        "@AppliesOrganisationTypeID,@CollectOrganisationTypeID,@RevenueProfileTypeID,@DeductionTypeID,@CreditOrganisationTypeID,@IsSplit",
                        new SqlParameter("@RevenueProfileID",revProfile.RevenueProfileID),
                        new SqlParameter("@RevenueProfileName", revProfile.RevenueProfileName),
                        new SqlParameter("@OrganisationID", revProfile.OrganisationID),
                        new SqlParameter("@DeductionTotalTypeID", revProfile.DeductionTotalTypeID),
                        new SqlParameter("@AppliesOrganisationTypeID", revProfile.AppliesOrganisationTypeID),
                        new SqlParameter("@CollectOrganisationTypeID", revProfile.CollectOrganisationTypeID),
                        new SqlParameter("@RevenueProfileTypeID", revProfile.RevenueProfileTypeID),
                        new SqlParameter("@DeductionTypeID", revProfile.DeductionTypeID),
                        new SqlParameter("@CreditOrganisationTypeID", revProfile.CreditOrganisationTypeID),
                        new SqlParameter("@IsSplit", false));
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public static EvolutionRepository.ManualModels.GetRevenueProfileResult GetOrgRevenueProfile(int OrganisationID,int skip, int take)
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    var Result = new EvolutionRepository.ManualModels.GetRevenueProfileResult();

                    List<EvolutionRepository.Models.RevenueProfile> profile = new List<EvolutionRepository.Models.RevenueProfile>();
                    profile = ctx.Database.SqlQuery<EvolutionRepository.Models.RevenueProfile>("GetOrgRevenueProfiles @OrganisationID,@skip,@take",
                        new SqlParameter("@OrganisationID", OrganisationID),
                        new SqlParameter("@skip", skip),
                        new SqlParameter("@take", take)).ToList();

                    Result.count = profile.Count;
                    Result.data = profile; // ctx.RevenueProfiles.Skip(skip).Take(take).ToList();
                    return Result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static List<EvolutionRepository.Models.RevenueProfileType> GetRevenueProfileType()
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    List<EvolutionRepository.Models.RevenueProfileType> profileTypes = new List<EvolutionRepository.Models.RevenueProfileType>();
                    profileTypes = ctx.Database.SqlQuery<EvolutionRepository.Models.RevenueProfileType>("GetRevenueProfileTypes").ToList();
                    return profileTypes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EvolutionRepository.Models.DeductionType> GetDeductionType()
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    List<EvolutionRepository.Models.DeductionType> deductionType = new List<EvolutionRepository.Models.DeductionType>();
                    deductionType = ctx.Database.SqlQuery<EvolutionRepository.Models.DeductionType>("GetDeductionTypes").ToList();
                    return deductionType;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<EvolutionRepository.Models.DeductionTotalType> GetDeductionTotalType()
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    List<EvolutionRepository.Models.DeductionTotalType> deductionTotalType = new List<EvolutionRepository.Models.DeductionTotalType>();
                    deductionTotalType = ctx.Database.SqlQuery<EvolutionRepository.Models.DeductionTotalType>("GetDeductionTotalTypes").ToList();
                    return deductionTotalType;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool DeleteOrganisationRevenueProfile(int organisationID)
        {
            bool Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_DeleteOrganisationRevenueProfile @RevenueProfileID",
                        new SqlParameter("@RevenueProfileID", organisationID));
                }
                Result = true;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            return Result;
        }


        public static bool SaveDailyDeductions(EvolutionRepository.Models.DailyDeduction dailyDeduction)
        {
            bool Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_DailyDeductionsSave @MachineID,@ApplicableDate,@RevenueProfileID,"+
                        "@SiteID,@CollectionOrganisationID,@CreditOrganisationID,@RatePercent,@Amount",
                        new SqlParameter("@MachineID", dailyDeduction.MachineID),
                        new SqlParameter("@ApplicableDate", dailyDeduction.ApplicableDate),
                        new SqlParameter("@RevenueProfileID", dailyDeduction.RevenueProfileID),
                        new SqlParameter("@SiteID", dailyDeduction.SiteID),
                        new SqlParameter("@CollectionOrganisationID", dailyDeduction.CollectionOrganisationID),
                        new SqlParameter("@CreditOrganisationID", dailyDeduction.CollectionOrganisationID),
                        new SqlParameter("@RatePercent", dailyDeduction.RatePercent),
                        new SqlParameter("@Amount", dailyDeduction.Amount));
                }
                Result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }


        public static List<EvolutionRepository.Models.DailyDeduction> GetDailyDeductions()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                List<EvolutionRepository.Models.DailyDeduction> deductions = new List<EvolutionRepository.Models.DailyDeduction>();
                deductions = ctx.Database.SqlQuery<EvolutionRepository.Models.DailyDeduction>("Evo_GetDailyDeductions").ToList();
                return deductions;
            }
        }

        public static EvolutionRepository.ManualModels.GetRevenueProfileScaleResult GetRevenueProfileScales(int revenueProfileID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                EvolutionRepository.ManualModels.GetRevenueProfileScaleResult result = new EvolutionRepository.ManualModels.GetRevenueProfileScaleResult();
                result.data = ctx.Database.SqlQuery<EvolutionRepository.Models.RevenueScale>("Evo_GetRevenueProfileScales @profileID", new SqlParameter("@profileID",revenueProfileID)).ToList();
                result.count = result.data.Count();
                return result;
            }
        }

        public static bool SaveRevenueProfileScale(EvolutionRepository.Models.RevenueScale revScale)
        {
            bool Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_SaveRevenueProfileScale @RevenueProfileID,@RevenueScaleID,@FixedAmount,@Limit,@Rate",
                        new SqlParameter("@RevenueProfileID", revScale.RevenueProfileID),
                        new SqlParameter("@RevenueScaleID", revScale.RevenueScaleID),
                        new SqlParameter("@FixedAmount", revScale.FixedAmount),
                        new SqlParameter("@Limit",revScale.Limit),
                        new SqlParameter("@Rate", revScale.Rate));
                }
                Result = true;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DeleteRevenueProfileScale(EvolutionRepository.ManualModels.RevenueProfileScaleKeys keys)
        {
            bool Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_DeleteRevenueProfileScale @RevenueProfileID,@RevenueScaleID",
                        new SqlParameter("@RevenueProfileID", keys.RevenueProfileID),
                        new SqlParameter("@RevenueScaleID", keys.RevenueScaleID));
                }
                Result = true;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
