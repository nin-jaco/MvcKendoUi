using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Organisation
    {
        public Organisation()
        {
            this.OrganisationsApprovedCertifiedModels = new List<ApprovedCertifiedModel>();
            this.OrganisationsAreas = new List<Area>();
            this.OrganisationsDailyAreas = new List<DailyArea>();
            this.OrganisationsDepartments = new List<Department>();
            this.OrganisationsEDCUnitSites = new List<EDCUnitSite>();
            this.OrganisationsFiscalYears = new List<FiscalYear>();
            this.OrganisationsInstructions = new List<Instruction>();
            this.Organisations1Instructions = new List<Instruction>();
            this.OrganisationsLicenses = new List<License>();
            this.OrganisationsLicenseTypes = new List<LicenseType>();
            this.OrganisationsNotifications = new List<Notification>();
            this.OrganisationsOrganisationAddresses = new List<OrganisationAddress>();
            this.OrganisationsOrganisationComms = new List<OrganisationComm>();
            this.OrganisationsOrganisationDeductions = new List<OrganisationDeduction>();
            this.OrganisationsOrganisationOptions = new List<OrganisationOption>();
            this.OrganisationsOrganisationTotals = new List<OrganisationTotal>();
            this.OrganisationsPrintJobs = new List<PrintJob>();
            this.OrganisationsRevenueProfiles = new List<RevenueProfile>();
            this.OrganisationAreasAreas = new List<Area>();
            this.OrganisationJurisdictionsJurisdictions = new List<Jurisdiction>();
            this.SiteInspectionsInspections = new List<Inspection>();
        }

        public int OrganisationID { get; set; }
        public string OrganisationName { get; set; }
        public string CompanyNumber { get; set; }
        public string TaxNumber { get; set; }
        public int OrganisationTypeID { get; set; }
        public Nullable<int> OrganisationSubTypeID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> MaximumMachines { get; set; }
        public Nullable<int> JurisdictionID { get; set; }
        public string TelephoneCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxCode { get; set; }
        public string FaxNumber { get; set; }
        public string ContactName { get; set; }
        public string EmailAddress { get; set; }
        public string WebSiteURL { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<int> BankAccountID { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public byte[] Timestamp { get; set; }
        public Nullable<int> OrganisationStatusID { get; set; }
        public virtual ICollection<ApprovedCertifiedModel> OrganisationsApprovedCertifiedModels { get; set; }
        public virtual ICollection<Area> OrganisationsAreas { get; set; }
        public virtual BankAccount BankAccountsBankAccount { get; set; }
        public virtual ICollection<DailyArea> OrganisationsDailyAreas { get; set; }
        public virtual ICollection<Department> OrganisationsDepartments { get; set; }
        public virtual ICollection<EDCUnitSite> OrganisationsEDCUnitSites { get; set; }
        public virtual ICollection<FiscalYear> OrganisationsFiscalYears { get; set; }
        public virtual ICollection<Instruction> OrganisationsInstructions { get; set; }
        public virtual ICollection<Instruction> Organisations1Instructions { get; set; }
        public virtual Jurisdiction JurisdictionsJurisdiction { get; set; }
        public virtual ICollection<License> OrganisationsLicenses { get; set; }
        public virtual ICollection<LicenseType> OrganisationsLicenseTypes { get; set; }
        public virtual ICollection<Notification> OrganisationsNotifications { get; set; }
        public virtual Operator OrganisationsOperator { get; set; }
        public virtual ICollection<OrganisationAddress> OrganisationsOrganisationAddresses { get; set; }
        public virtual ICollection<OrganisationComm> OrganisationsOrganisationComms { get; set; }
        public virtual ICollection<OrganisationDeduction> OrganisationsOrganisationDeductions { get; set; }
        public virtual ICollection<OrganisationOption> OrganisationsOrganisationOptions { get; set; }
        public virtual OrganisationType OrganisationTypesOrganisationType { get; set; }
        public virtual ICollection<OrganisationTotal> OrganisationsOrganisationTotals { get; set; }
        public virtual ICollection<PrintJob> OrganisationsPrintJobs { get; set; }
        public virtual ICollection<RevenueProfile> OrganisationsRevenueProfiles { get; set; }
        public virtual Site OrganisationsSite { get; set; }
        public virtual ICollection<Area> OrganisationAreasAreas { get; set; }
        public virtual ICollection<Jurisdiction> OrganisationJurisdictionsJurisdictions { get; set; }
        public virtual ICollection<Inspection> SiteInspectionsInspections { get; set; }
    }
}
