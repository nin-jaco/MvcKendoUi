using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Validation;

namespace EvolutionDataAccess.Employee
{
    public class EmployeeDAL
    {
        //public class GetEmployeeListResult
        //{
        //    public List<EvolutionRepository.Models.Employee> data; // must contain only the record on the current page (apply the skip and take)
        //    public int count; // Must contain the TOTAL number of records that the user can page through
        //}

        public static EvolutionRepository.ManualModels.GetEmployeeListResult GetEmployees(EvolutionRepository.ManualModels.SearchEmployeeParams searchParams)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;

                var Result = new EvolutionRepository.ManualModels.GetEmployeeListResult();

                // Build the WHERE clause
                List<Filter> filter = new List<Filter>();
                if (!String.IsNullOrEmpty(searchParams.FirstName))
                {
                    filter.Add(new Filter { PropertyName = "FirstName", Operation = Op.Contains, Value = searchParams.FirstName });
                }
                if (!String.IsNullOrEmpty(searchParams.LastName))
                {
                    filter.Add(new Filter { PropertyName = "LastName", Operation = Op.Contains, Value = searchParams.LastName });
                }
                if (searchParams.EmployeeTypeID > 0)
                {
                    filter.Add(new Filter { PropertyName = "EmployeeTypeID", Operation = Op.Equals, Value = searchParams.EmployeeTypeID });
                }
                if (searchParams.OrganisationID > 0)
                {
                    filter.Add(new Filter { PropertyName = "OrganisationID", Operation = Op.Equals, Value = searchParams.OrganisationID });
                }
                var deleg = ExpressionBuilder.GetExpression<EvolutionRepository.Models.Employee>(filter).Compile();

                // Always filter by Organisations in the OrgTree
                var userSession = ctx.UserSessions.Where(p => p.SessionID == searchParams.sessionID).First();
                var EmployeeSelect = ctx.Employees.Join(ctx.OrgTrees.Where(o => o.TopOrganisationID == userSession.TopOrganisationID), e => e.OrganisationID, o => o.OrganisationID, (e, o) => e).Where(deleg);
                var EmployeeList = EmployeeSelect.Skip(searchParams.skip).Take(searchParams.take).ToList();

                if (EmployeeList != null)
                {
                    Result.Count = EmployeeSelect.Count();
                    var employeeManualList = new List<EvolutionRepository.ManualModels.EmployeeGrid>();
                    foreach (var item in EmployeeList)
                    {
                        employeeManualList.Add(new EvolutionRepository.ManualModels.EmployeeGrid
                        {
                            EmployeeID = item.EmployeeID,
                            EmployeeName = item.FirstName + ' ' + item.LastName,
                            Employer = ctx.Organisations.Where(p => p.OrganisationID == item.OrganisationID).FirstOrDefault().OrganisationName,
                            EmployeeTypeName = ctx.EmployeeTypes.Where(p => p.EmployeeTypeID == item.EmployeeTypeID).FirstOrDefault().EmployeeTypeName,
                            EmployeeStatusName = ctx.EmployeeStatuses.Where(p => p.EmployeeStatusID == item.EmployeeStatusID).FirstOrDefault().EmployeeStatusName
                        });
                    }
                    Result.Data = employeeManualList;

                    return Result;
                }
                return null;
            }
        }

        public static List<EvolutionRepository.ManualModels.EmployeeGrid> GetEmployees(EvolutionRepository.ManualModels.SearchEmployeeParams searchParams, EvolutionRepository.Models.User LoggedInUser, out int TotalInstancesWithoutSkipTake)
        {
            List<EvolutionRepository.ManualModels.EmployeeGrid> Employees = new List<EvolutionRepository.ManualModels.EmployeeGrid>();

            using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                try
                {
                    Employees = ctx.Database.SqlQuery<EvolutionRepository.ManualModels.EmployeeGrid>(
                        "Ev_EmployeeSearch @FirstName, @EmployeeTypeID",
                        new SqlParameter("@FirstName", searchParams.FirstName),
                        new SqlParameter("@EmployeeTypeID", searchParams.EmployeeTypeID))
                        .ToList();

                    TotalInstancesWithoutSkipTake = Employees.Count;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return Employees.OrderBy(x => x.EmployeeID).Skip(searchParams.skip).Take(searchParams.take).ToList();
        }

        public static bool UpdateEmployee(EvolutionRepository.Models.Employee UpdateEmp)
        {
            var Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    var DBEmp = ctx.Employees.FirstOrDefault(x => x.EmployeeID == UpdateEmp.EmployeeID);
                    //DBEmp.BankAccountID = UpdateEmp.BankAccountID;
                    //DBEmp.CompanyNumber = UpdateEmp.CompanyNumber;
                    //DBEmp.ContactName = UpdateEmp.ContactName;
                    //DBEmp.EmailAddress = UpdateEmp.EmailAddress;
                    //DBEmp.FaxCode = UpdateEmp.FaxCode;
                    //DBEmp.FaxNumber = UpdateEmp.FaxNumber;
                    //DBEmp.JurisdictionID = UpdateEmp.JurisdictionID;
                    //DBEmp.Latitude = UpdateEmp.Latitude;
                    //DBEmp.Longitude = UpdateEmp.Longitude;
                    //DBEmp.MaximumMachines = UpdateEmp.MaximumMachines;
                    //DBEmp.EmployeeName = UpdateEmp.EmployeeName;
                    //DBEmp.EmployeeStatusID = UpdateEmp.EmployeeStatusID;
                    //DBEmp.EmployeeSubTypeID = UpdateEmp.EmployeeSubTypeID;
                    //DBEmp.EmployeeTypeID = UpdateEmp.EmployeeTypeID;
                    //DBEmp.ParentID = UpdateEmp.ParentID;
                    //DBEmp.TaxNumber = UpdateEmp.TaxNumber;
                    //DBEmp.TelephoneCode = UpdateEmp.TelephoneCode;
                    //DBEmp.TelephoneNumber = UpdateEmp.TelephoneNumber;
                    //DBEmp.Timestamp = System.Text.ASCIIEncoding.Unicode.GetBytes(DateTime.Now.ToString());
                    //DBEmp.WebSiteURL = UpdateEmp.WebSiteURL;
                    ctx.SaveChanges();

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


        public static bool CreateEmployee(EvolutionRepository.Models.Employee CreateEmp)
        {
            var Result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    if (Object.Equals(null, ctx.Employees.FirstOrDefault(x => x.EmployeeID == CreateEmp.EmployeeID)))
                    {
                        ctx.Employees.Add(CreateEmp);
                        ctx.SaveChanges();
                    }

                    Result = true;
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(ErrorHandler.BuildDbEntityValidationErrorMessage(ex), ex.EntityValidationErrors);
            }
            catch (Exception ex)
            {
                Result = false;
                throw ex;
            }
            return Result;
        }

        public static List<EvolutionRepository.Models.EmployeeType> GetEmpTypes()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                var result = ctx.EmployeeTypes.ToList();
                return result;
            }
        }

        public static List<EvolutionRepository.Models.Title> GetTitles()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                var result = ctx.Titles.ToList();
                return result;
            }
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictions()
        {
            List<EvolutionRepository.Models.Jurisdiction> jurisdictions = new List<EvolutionRepository.Models.Jurisdiction>();
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    return ctx.Jurisdictions.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<EvolutionRepository.Models.EmployeeStatus> GetEmpStatuses()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                var result = ctx.EmployeeStatuses.ToList();
                return result;
            }
            //try
            //{
            //    using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            //    {
            //        return ctx.EmployeeStatuses.ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}
