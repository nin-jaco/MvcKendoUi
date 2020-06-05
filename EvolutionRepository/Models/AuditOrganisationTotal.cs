using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditOrganisationTotal
    {
        public AuditOrganisationTotal()
        {
            this.AuditOrganisationTotalsAuditOrganisationDeductions = new List<AuditOrganisationDeduction>();
        }

        public int AuditFiscalYearID { get; set; }
        public int AuditFiscalPeriodID { get; set; }
        public int AuditOrganisationID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string AuditOrganisationName { get; set; }
        public int OrganisationTypeID { get; set; }
        public string OrganisationTypeName { get; set; }
        public Nullable<int> JurisdictionID { get; set; }
        public string JurisdictionName { get; set; }
        public Nullable<int> OrganisationSubTypeID { get; set; }
        public string OrganisationSubTypeName { get; set; }
        public Nullable<int> MaximumMachines { get; set; }
        public Nullable<int> NoOfMachines { get; set; }
        public Nullable<int> NoOfChildren { get; set; }
        public Nullable<int> NoOfEmployees { get; set; }
        public Nullable<int> NoOfChildEmployees { get; set; }
        public Nullable<int> NoOfStockMachines { get; set; }
        public Nullable<int> NoOfSites { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalCity { get; set; }
        public string PostalJurisdiction { get; set; }
        public Nullable<int> BankAccountID { get; set; }
        public string BankAccountHolder { get; set; }
        public string BankAccountNumber { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string BranchCode { get; set; }
        public decimal TotalCoinsIn { get; set; }
        public decimal TotalCoinboxDrop { get; set; }
        public decimal TotalCoinRefill { get; set; }
        public decimal TotalCoinsOut { get; set; }
        public decimal TotalCoinDump { get; set; }
        public decimal TotalNotesIn { get; set; }
        public decimal TotalCashIn { get; set; }
        public decimal TotalCashOut { get; set; }
        public decimal TotalCashlessIn { get; set; }
        public decimal TotalCashlessOut { get; set; }
        public decimal TotalBet { get; set; }
        public decimal TotalWin { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalResets { get; set; }
        public decimal TotalHandPays { get; set; }
        public int TotalDoorOpens { get; set; }
        public int TotalCashDoorOpens { get; set; }
        public int TotalLogicDoorOpens { get; set; }
        public int TotalCallAttendants { get; set; }
        public decimal TotalProgressiveWin { get; set; }
        public decimal DoubleUpIn { get; set; }
        public decimal DoubleUpOut { get; set; }
        public decimal RemoteCashIn { get; set; }
        public decimal RemoteCashOut { get; set; }
        public decimal GrossGamingRevenue { get; set; }
        public decimal NettGamingRevenue { get; set; }
        public Nullable<decimal> SiteShare { get; set; }
        public Nullable<double> OrganisationIndex { get; set; }
        public Nullable<int> AccountTypeID { get; set; }
        public string AccountTypeName { get; set; }
        public string BankAccountTypeCode { get; set; }
        public virtual AuditFiscalPeriod AuditFiscalPeriodsAuditFiscalPeriod { get; set; }
        public virtual ICollection<AuditOrganisationDeduction> AuditOrganisationTotalsAuditOrganisationDeductions { get; set; }
    }
}
