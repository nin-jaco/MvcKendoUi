using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Bank
    {
        public Bank()
        {
            this.BanksBankAccounts = new List<BankAccount>();
            this.BanksBankAccountTypes = new List<BankAccountType>();
        }

        public int BankID { get; set; }
        public string BankName { get; set; }
        public virtual ICollection<BankAccount> BanksBankAccounts { get; set; }
        public virtual ICollection<BankAccountType> BanksBankAccountTypes { get; set; }
    }
}
