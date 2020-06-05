using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.Models;
using EvolutionRepository.ManualModels;

namespace EvolutionBusinessLogic.EmployeesLogic
{
    public class EmployeeBusinessLogic
    {
        public static Employee GetEmployee(int employeeID)
        {
            return new Employee();
        }
        public static GetEmployeeListResult GetEmployees(int skip, int take)
        {
            GetEmployeeListResult EmpListResult = new GetEmployeeListResult();
            return EmpListResult;

            //return EvolutionDataAccess.Employee.EmployeeDAL.GetEmployees(skip, take);
        }

        public static bool UpdateEmployee(EvolutionRepository.Models.Employee UpdateEmp)
        {
            var Result = false;
            try
            {
                EvolutionDataAccess.Employee.EmployeeDAL.UpdateEmployee(UpdateEmp);
                Result = true;
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
            return Result;
        }

        public static bool CreateEmployee(EvolutionRepository.Models.Employee CreateEmp)
        {
            var Result = false;
            try
            {
                EvolutionDataAccess.Employee.EmployeeDAL.CreateEmployee(CreateEmp);
                Result = true;
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
            return Result;
        }

        public static bool DeleteEmployee(int Id)
        {
            var Result = false;

            try
            {
                //EvolutionDataAccess.Employee.EmployeeDAL.DeleteEmployee(Id);
                Result = true;
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }

            return Result;
        }

        public static List<EvolutionRepository.Models.EmployeeType> GetEmpTypes()
        {
            List<EvolutionRepository.Models.EmployeeType> EmpTypesList = new List<EvolutionRepository.Models.EmployeeType>();
            try
            {
                return EvolutionDataAccess.Employee.EmployeeDAL.GetEmpTypes();              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictions()
        {
            List<EvolutionRepository.Models.Jurisdiction> jurisdictions = new List<EvolutionRepository.Models.Jurisdiction>();
            try
            {
                return EvolutionDataAccess.Employee.EmployeeDAL.GetJurisdictions();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EvolutionRepository.Models.EmployeeStatus> GetEmpStatuses()
        {
            try
            {
                return EvolutionDataAccess.Employee.EmployeeDAL.GetEmpStatuses();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
