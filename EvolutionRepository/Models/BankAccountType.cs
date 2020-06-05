using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class BankAccountType
    {
        public int BankID { get; set; }
        public int AccountTypeID { get; set; }
        public string BankAccountTypeCode { get; set; }
        public virtual AccountType AccountTypesAccountType { get; set; }
        public virtual Bank BanksBank { get; set; }
    }
}
