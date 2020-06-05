using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class GetOrganistionListResult
    {
        public List<EvolutionRepository.Models.Organisation> data; // must contain only the record on the current page (apply the skip and take)
        public int count; // Must contain the TOTAL number of records that the user can page through
    }

    public class GetRevenueProfileResult
    {
        public List<EvolutionRepository.Models.RevenueProfile> data;
        public int count;
    }

    public class GetRevenueProfileScaleResult
    {
        public List<EvolutionRepository.Models.RevenueScale> data;
        public int count;
    }


    public class GetOrganisationList
    {
        public List<OrganisationManualModel> data; // must contain only the record on the current page (apply the skip and take)
        public int count; // Must contain the TOTAL number of records that the user can page through
    }

    public class OrganisationManualModel
    {
        public int ID { get; set; }
        public string OrgName { get; set; }
        public string ContactPerson { get; set; }
        public string OrgType { get; set; }
        public string OrgSubType { get; set; }
        public string Jurisdiction { get; set; }
        public string District { get; set; }
        public string ParentOrganisation { get; set; }
        public string RegistrationNo { get; set; }
        public string MaximumMachines { get; set; }
        public string AssignedArea { get; set; }
        public string VATVendor { get; set; }
        public string PhysicalAddressStreet1 { get; set; }
        public string PhysicalAddressStreet2 { get; set; }
        public string PhysicalAddressSurburb { get; set; }
        public string PhysicalAddressCity { get; set; }
        public string PhysicalAddressProvince { get; set; }
        public string PhysicalAddressPostalCode { get; set; }
        public string PostalAddressStreet1 { get; set; }
        public string PostalAddressStreet2 { get; set; }
        public string PostalAddressSurburb { get; set; }
        public string PostalAddressCity { get; set; }
        public string PostalAddressProvince { get; set; }
        public string PostalAddressPostalCode { get; set; }       
        public string GPSCoordinates { get; set; }
        public string SiteStatus { get; set; }
        public string AccountManager { get; set; }
        public string Collector { get; set; }
        public string SiteManager { get; set; }
        public string DefaultSplit { get; set; }
        public string SignedBy { get; set; }
        public string SignedByDate { get; set; }
        public string CashCollection { get; set; }
        public string LiquorLicenseNo { get; set; }
        public string BusinessLicenseNo { get; set; }
        public string Classification { get; set; }
        public string PDI { get; set; }
        public string PLAInvestigator { get; set; }
        public string PLAInspector { get; set; }
    }


    //public class OrganisationType
    //{
    //    public int TypeID { get; set; }
    //    public string TypeName { get; set; }
    //}

    //public class OrganisationSubType
    //{
    //    public int SubTypeID { get; set; }
    //    public string SubTypeName { get; set; }
    //}

    public class OrganisationGrid
    {
        public int OrganisationID { get; set; }
        public string OrganisationName { get; set; }
        public string CompanyNumber { get; set; }
        public string TelephoneNo { get; set; }
        public string ContactName { get; set; }
        public string WebSiteURL { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public string OrganisationStatusName { get; set; }
    }

    public class RevenueProfileScaleKeys
    {
        public int RevenueProfileID { get; set; }
        public int RevenueScaleID { get; set; }
    }
}