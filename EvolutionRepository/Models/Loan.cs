using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Loan
    {
        public Loan()
        {
            this.LoansLoanRepayments = new List<LoanRepayment>();
        }

        public int LoanID { get; set; }
        public int RevenueProfileID { get; set; }
        public int BorrowerOrganisationID { get; set; }
        public int StartFiscalYearID { get; set; }
        public int StartFiscalPeriodID { get; set; }
        public decimal TotalLoanAmount { get; set; }
        public decimal TotalRepaymentAmount { get; set; }
        public decimal LoanBalance { get; set; }
        public decimal PeriodRepaymentAmount { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public System.DateTime DateAdded { get; set; }
        public virtual ICollection<LoanRepayment> LoansLoanRepayments { get; set; }
        public virtual RevenueProfile RevenueProfilesRevenueProfile { get; set; }
    }
}
