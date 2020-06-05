using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionDataAccess.Search;

namespace EvolutionBusinessLogic.Search
{
    public class SearchEmployees
    {
        private static int TotalInstancesWithoutSkipTake = 0;

        public static EvolutionRepository.ManualModels.GetEmployeeListResult EmployeeList(EvolutionRepository.ManualModels.SearchEmployeeParams searchParams)
        {
            //EvolutionRepository.ManualModels.EmployeeGrid EmployeeList = new EvolutionRepository.ManualModels.EmployeeGrid();
            return EvolutionDataAccess.Employee.EmployeeDAL.GetEmployees(searchParams);
        }
        
        //public static EvolutionRepository.ManualModels.SearchResult SearchForEmployees(EvolutionRepository.ManualModels.SearchEmployeeParams searchParams, EvolutionRepository.Models.User LoggedInUser)
        //{
        //    var EmployeesFound = new List<EvolutionRepository.ManualModels.EmployeeGrid>();

        //    try
        //    {
        //        //Call DAL and return Employee that the user is allowesd to within the search params
        //        var FoundEmployees = EvolutionDataAccess.Employee.EmployeeDAL.GetEmployees(searchParams, LoggedInUser, out TotalInstancesWithoutSkipTake);

        //        foreach (var foundEmployee in FoundEmployees)
        //        {
        //            var newEmployee = new EvolutionRepository.ManualModels.EmployeeGrid()
        //            {
        //                EmployeeID = foundEmployee.EmployeeID,
        //                FirstName = foundEmployee.FirstName,
        //                LastName = foundEmployee.LastName,
        //                IdentificationNumber = foundEmployee.IdentificationNumber,
        //            };

        //            EmployeesFound.Add(newEmployee);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
        //    }

        //    return new EvolutionRepository.ManualModels.SearchResult(EmployeesFound.ToArray(), TotalInstancesWithoutSkipTake);
        //}

    }
}
