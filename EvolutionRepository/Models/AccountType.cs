using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            this.AccountTypesBankAccounts = new List<BankAccount>();
            this.AccountTypesBankAccountTypes = new List<BankAccountType>();
        }

        public int AccountTypeID { get; set; }
        public string AccountTypeName { get; set; }
        public virtual ICollection<BankAccount> AccountTypesBankAccounts { get; set; }
        public virtual ICollection<BankAccountType> AccountTypesBankAccountTypes { get; set; }
    }
}
