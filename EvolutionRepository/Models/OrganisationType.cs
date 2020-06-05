using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class OrganisationType
    {
        public OrganisationType()
        {
            this.OrganisationTypesLicenseTypes = new List<LicenseType>();
            this.OrganisationTypesOrganisationChildSubTypes = new List<OrganisationChildSubType>();
            this.OrganisationTypesOrganisations = new List<Organisation>();
            this.OrganisationTypesOrganisationSubTypes = new List<OrganisationSubType>();
            this.OrganisationTypesRevenueProfiles = new List<RevenueProfile>();
            this.OrganisationTypes1RevenueProfiles = new List<RevenueProfile>();
            this.OrganisationTypes2RevenueProfiles = new List<RevenueProfile>();
            this.OrganisationEmployeeTypesEmployeeTypes = new List<EmployeeType>();
            this.OrganisationTypeModulesModules = new List<Module>();
        }

        public int OrganisationTypeID { get; set; }
        public string OrganisationTypeName { get; set; }
        public bool IsLicensed { get; set; }
        public bool IsBasedOnMachineRevenue { get; set; }
        public Nullable<bool> HasSplits { get; set; }
        public Nullable<bool> HasRevenueProfiles { get; set; }
        public Nullable<bool> HasFiscalPeriods { get; set; }
        public Nullable<bool> HasAreas { get; set; }
        public Nullable<bool> HasDepartments { get; set; }
        public Nullable<bool> HasContacts { get; set; }
        public Nullable<bool> HasBankAccounts { get; set; }
        public Nullable<bool> HasActiveDailyPeriods { get; set; }
        public Nullable<bool> HasCommunications { get; set; }
        public Nullable<bool> HasLicenses { get; set; }
        public Nullable<bool> HasLocations { get; set; }
        public Nullable<bool> HasEmployees { get; set; }
        public Nullable<bool> HasMachines { get; set; }
        public Nullable<bool> ApprovesMachines { get; set; }
        public Nullable<bool> ApprovesMovements { get; set; }
        public Nullable<bool> RequestsMovements { get; set; }
        public Nullable<bool> HasInvoices { get; set; }
        public Nullable<bool> HasLoans { get; set; }
        public virtual ICollection<LicenseType> OrganisationTypesLicenseTypes { get; set; }
        public virtual ICollection<OrganisationChildSubType> OrganisationTypesOrganisationChildSubTypes { get; set; }
        public virtual ICollection<Organisation> OrganisationTypesOrganisations { get; set; }
        public virtual ICollection<OrganisationSubType> OrganisationTypesOrganisationSubTypes { get; set; }
        public virtual ICollection<RevenueProfile> OrganisationTypesRevenueProfiles { get; set; }
        public virtual ICollection<RevenueProfile> OrganisationTypes1RevenueProfiles { get; set; }
        public virtual ICollection<RevenueProfile> OrganisationTypes2RevenueProfiles { get; set; }
        public virtual ICollection<EmployeeType> OrganisationEmployeeTypesEmployeeTypes { get; set; }
        public virtual ICollection<Module> OrganisationTypeModulesModules { get; set; }
    }
}
