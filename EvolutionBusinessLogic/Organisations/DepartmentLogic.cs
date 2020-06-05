using EvolutionDataAccess.Organisation;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Organisations
{
    public class DepartmentLogic
    {
        public static EvolutionRepository.ManualModels.GetDepartmentListResult GetAllDepartmentsByID(int organisationID, int skip, int take)
        {
            try
            {
                return DepartmentDAL.GetAllDepartmentsByID(organisationID, skip, take);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool EditDepartment(Department department)
        {
            try
            {
                return DepartmentDAL.EditDepartment(department);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool InsertOrganisationComm(Department department)
        {
            try
            {
                return DepartmentDAL.InsertDepartment(department);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool DeleteOrganisationComm(int departmentID)
        {
            try
            {
                return DepartmentDAL.DeleteDepartment(departmentID);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }
    }
}
