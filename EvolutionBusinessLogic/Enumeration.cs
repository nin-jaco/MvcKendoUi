using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic
{
    public class Enumeration
    {
        public enum CreateUserStatus
        {
            Successful,
            DuplicateUsername,
            DuplicateEmail,
            InvalidPassword,
            InvalidEmail,
            InvalidAnswer,
            InvalidQuestion,
            InvalidUsername,
            ProviderError,
            UserRejected,
            Error
        }

        public enum ApprovalTaskStatus
        {
            Pending,
            Complete,
            Expired
        }

        public enum ApprovalStage
        {
            None,
            Review,
            Approve
        }

        public enum ApprovalOutcome
        {
            None,
            Pending,
            Reviewed,
            Approved,
            Rejected,
            Expired
        }

        public enum MessageType
        {
            Email,
            SMS
        }

        public enum Gender
        {
            Unknown,
            Male,
            Female
        }

        public enum OrganisationDataType
        {
            Organisations,
            Employees,
            Communications,
            Areas,
            Departments,
            BankingDetails,
            Splits,
            Deductions,
            VATInvoices,
            ActiveDailyPeriods,
            Contacts,
            Locations,
            FiscalYears,
            ApprovedMachines,
            Licenses,
            LicenseTypes
        }

        public enum EmployeeDataType
        {
            Employees,
            Licenses
        }

        public enum MasterDataType
        {
            Areas,
            Suburbs,
            City,
            Districts,
            Banks,
            Titles,
            EmployeeStatuses,
            LicenseStatuses,
            CommunicationsType,
            Jurisdictions,
            Entitytypes
        }

        public enum JurisdictionType
        {
            User,
            All,
            ID,
            Name,
            Type,
            Parent
        }

        public enum OrganisationType
        {
            Type,
            SubType
        }
    }
}
