using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionRepository.ManualModels;
//using EvolutionRepository.GridsData;
using EvolutionBusinessLogic.Employees;
using EvolutionRepository.Models;

namespace EvolutionWeb.Controllers.api
{
    public class EmployeeController : ApiController
    {
        // GET api/Employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // GET api/Employee
        public GetEmployeeListResult GetEmployees([FromUri]int skip, int take)//EmployeeBusinessLogic.GetEmployeeListResult GetEmployees([FromUri]int skip, int take)
        {
            return EmployeeBL.GetEmployees(skip, take);
            //var AllPeople = Code.PersonLogic.GetAllPeople(skip, take);
            //return AllPeople;
            //GetEmployees LstEmps = new GetEmployees();
            /*GetEmployeeListResult LstEmps = new GetEmployeeListResult();
            Employee Emp = new Employee();
            //Emp.AccountManager = "Test Data";
            Emp.EmpName = "My New Employee";
            Emp.ContactPerson = "Never Makosa";
            Emp.ID = 1;
            LstEmps.data = new List<Employee>();
            LstEmps.data.Add(Emp);
            LstEmps.count = 1;
            return LstEmps;*/
            //List<Employee> Lst = new List<Employee>();
            //Lst.Add(Emp);
            //return Lst;
            //string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(Emp);
            //return json;
        }

        //public IEnumerable<EvolutionRepository.Models.EmployeeType> PostEmployeeTypes()
        //{
        //    List<EvolutionRepository.Models.EmployeeType> EmployeeTypes = EvolutionBusinessLogic.Employees.EmployeeBL.GetEmpTypes();

        //    return EmployeeTypes;
        //}

        public IEnumerable<EvolutionRepository.Models.Title> GetTitles()
        {
            List<EvolutionRepository.Models.Title> Titles = EvolutionBusinessLogic.Employees.EmployeeBL.GetTitles();

            return Titles;
        }

        public string GetEmpJurisdiction()
        {
            List<EvolutionRepository.Models.Jurisdiction> lstJRD = new List<EvolutionRepository.Models.Jurisdiction>();
            lstJRD = EvolutionBusinessLogic.Employees.EmployeeBL.GetJurisdictions();
            var lst = new List<EvolutionRepository.Models.Jurisdiction>();
            foreach (var v in lstJRD)
            {
                EvolutionRepository.Models.Jurisdiction jrd = new Jurisdiction();
                jrd.JurisdictionID = v.JurisdictionID;
                jrd.JurisdictionName = v.JurisdictionName;
                lst.Add(jrd);
                jrd = null;
            }
            var JsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            JsonSerializer.MaxJsonLength = Int32.MaxValue;
            string json = JsonSerializer.Serialize(lst); // new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lst);
            return json; 
        }

        public string GetEmployeeStatuses()
        {
            List<EvolutionRepository.Models.EmployeeStatus> lstStatuses = new List<EvolutionRepository.Models.EmployeeStatus>();
            lstStatuses = EvolutionBusinessLogic.Employees.EmployeeBL.GetEmpStatuses();
            var lst = new List<EvolutionRepository.Models.EmployeeStatus>();
            foreach (var v in lstStatuses)
            {
                EvolutionRepository.Models.EmployeeStatus status = new EmployeeStatus();
                status.EmployeeStatusID = v.EmployeeStatusID;
                status.EmployeeStatusName = v.EmployeeStatusName;
                lst.Add(status);
            }
            string json =  new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lst);
            return json; 
        }

        // POST api/Employee
        public HttpResponseMessage Post([FromBody]Employee Employee)
        {
            //EmployeeMethods Emp = new EmployeeMethods();
            //bool Result = Emp.CreateEmployee(Employee);
            try
            {
                bool Result = EmployeeBL.CreateEmployee(Employee);
                if (Result == false)
                {
                    throw new HttpResponseException(HttpStatusCode.BadRequest);
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                //Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage(HttpStatusCode.BadRequest);
                httpResponseMessage.Content = new StringContent(ex.Message);
                return httpResponseMessage;
            }
        }

        // PUT api/Employee/5
        public HttpResponseMessage Put([FromBody]Employee Employee)
        {
            //EmployeeMethods Emp = new EmployeeMethods();
            //bool Result = Emp.UpdateEmployee(Employee);
            bool Result = EmployeeBL.UpdateEmployee(Employee);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

        // DELETE api/Employee/5
        public HttpResponseMessage Delete(int id)
        {
            //EmployeeMethods Emp = new EmployeeMethods();
            //bool Result = Emp.DeleteEmployee(id);
            bool Result = EmployeeBL.DeleteEmployee(id);
            if (Result == false)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }


    }
}
