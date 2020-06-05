using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionDataAccess.Organisation
{
    public class DepartmentDAL
    {
        public static EvolutionRepository.ManualModels.GetDepartmentListResult GetAllDepartmentsByID(int organisationID, int skip, int take)
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    int TotalInstancesWithoutSkipTake;

                    ctx.Configuration.ProxyCreationEnabled = false;
                    var departmentList = ctx.Departments.Where(p => p.OrganisationID == organisationID).ToList();

                    if (departmentList != null)
                    {
                        TotalInstancesWithoutSkipTake = departmentList.Count();
                        departmentList = departmentList.OrderBy(x => x.DepartmentID).Skip(skip).Take(take).ToList();

                        return new EvolutionRepository.ManualModels.GetDepartmentListResult(departmentList.ToArray(), TotalInstancesWithoutSkipTake);
                    }
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteDepartment(int departmentID)
        {
            bool result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_Departments_Delete  @DepartmentID",

                       new SqlParameter("@OrganisationID", departmentID)
                    );
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public static bool InsertDepartment(EvolutionRepository.Models.Department department)
        {
            bool result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_Departments_Insert  @OrganisationID,@DepartmentName,@DepartmentParentID",

                       new SqlParameter("@OrganisationID", department.OrganisationID),
                       new SqlParameter("@DepartmentName", department.DepartmentName),
                       new SqlParameter("@DepartmentParentID", department.DepartmentParentID)
                    );
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public static bool EditDepartment(EvolutionRepository.Models.Department department)
        {
            bool result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_Departments_Insert  @DepartmentID, @OrganisationID,@DepartmentName,@DepartmentParentID",

                       new SqlParameter("@DepartmentID", department.OrganisationID),
                       new SqlParameter("@OrganisationID", department.OrganisationID),
                       new SqlParameter("@DepartmentName", department.DepartmentName),
                       new SqlParameter("@DepartmentParentID", department.DepartmentParentID)
                    );
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
