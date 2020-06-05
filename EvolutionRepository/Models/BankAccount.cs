using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            this.BankAccountsOrganisations = new List<Organisation>();
        }

        public int OrganisationID { get; set; }
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public int BankID { get; set; }
        public string Branch { get; set; }
        public string BranchCode { get; set; }
        public Nullable<int> AccountTypeID { get; set; }
        public virtual AccountType AccountTypesAccountType { get; set; }
        public virtual Bank BanksBank { get; set; }
        public virtual ICollection<Organisation> BankAccountsOrganisations { get; set; }
    }
}
