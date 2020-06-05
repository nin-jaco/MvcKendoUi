using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class LoanRepayment
    {
        public int LoanID { get; set; }
        public System.DateTime DateOfPayment { get; set; }
        public decimal AmountPaid { get; set; }
        public int EmployeeID { get; set; }
        public string Comments { get; set; }
        public virtual Loan LoansLoan { get; set; }
    }
}
