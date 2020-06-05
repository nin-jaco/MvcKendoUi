using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class GetEmployeeListResult
    {
        public List<EvolutionRepository.ManualModels.EmployeeGrid> Data; // must contain only the record on the current page (apply the skip and take)
        public int Count; // Must contain the TOTAL number of records that the user can page through
    }
    public class EmployeeGrid
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Employer { get; set; }
        public string EmployeeTypeName { get; set; }
        public string EmployeeStatusName { get; set; }
    }
    //public class EmployeeManualModel
    //{
    //    [Key]
    //    public Int32 Id { get; set; }
        
    //    public Title Title { get; set; }

    //    [Required()]
    //    public String FirstName { get; set; }

    //    [Required()]
    //    public String LastName { get; set; }

    //    public String MiddleNames { get; set; }

    //    [Required()]
    //    public String IdPassportNumber { get; set; }

    //    [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
    //    public DateTime DateofBirth { get; set; }

    //    [DataType(DataType.PhoneNumber)]
    //    public String MobilePhone { get; set; }

    //    [DataType(DataType.PhoneNumber)]
    //    public String HomeTelephone { get; set; }

    //    public String OtherContact { get; set; }

    //    public String Employer { get; set; }

    //    public virtual JobType JobType { get; set; }

    //    public virtual EmployeeStatusManualModel EmployeeStatus { get; set; }

    //    public virtual Area Area { get; set; }

    //    public virtual Department Department { get; set; }

    //    [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
    //    public DateTime DateHired { get; set; }

    //    [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
    //    public DateTime DateLeft { get; set; }

    //}
}