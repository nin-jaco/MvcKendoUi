using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Employees1CardData = new List<CardData>();
            this.EmployeesCards = new List<Card>();
            this.EmployeesDailyAreas = new List<DailyArea>();
            this.Employees1DailyAreas = new List<DailyArea>();
            this.EmployeesEmployeeAddresses = new List<EmployeeAddress>();
            this.EmployeesInstructions = new List<Instruction>();
            this.EmployeesLicenses = new List<License>();
            this.EmployeesNotifications = new List<Notification>();
            this.EmployeesPhotoEmployees = new List<PhotoEmployee>();
        }

        public int EmployeeID { get; set; }
        public Nullable<int> AreaID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public int EmployeeTypeID { get; set; }
        public int OrganisationID { get; set; }
        public int TitleID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string HomePhone { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateHired { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public string TrainingComments { get; set; }
        public string Comments { get; set; }
        public string MobilePhone { get; set; }
        public byte[] Timestamp { get; set; }
        public Nullable<int> EmployeeStatusID { get; set; }
        public virtual ICollection<CardData> Employees1CardData { get; set; }
        public virtual ICollection<Card> EmployeesCards { get; set; }
        public virtual ICollection<DailyArea> EmployeesDailyAreas { get; set; }
        public virtual ICollection<DailyArea> Employees1DailyAreas { get; set; }
        public virtual Department DepartmentsDepartment { get; set; }
        public virtual ICollection<EmployeeAddress> EmployeesEmployeeAddresses { get; set; }
        public virtual EmployeeStatus EmployeeStatusesEmployeeStatus { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Title TitlesTitle { get; set; }
        public virtual ICollection<Instruction> EmployeesInstructions { get; set; }
        public virtual ICollection<License> EmployeesLicenses { get; set; }
        public virtual ICollection<Notification> EmployeesNotifications { get; set; }
        public virtual ICollection<PhotoEmployee> EmployeesPhotoEmployees { get; set; }
        public virtual User EmployeesUser { get; set; }
    }
}
