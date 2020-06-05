using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class BankingDetails
    {
        [Key]
        public Int32 Id { get; set; }

        [DataType(DataType.CreditCard)]
        public String AccountNumber { get; set; }

        public virtual Bank Bank { get; set; }

        public virtual AccountType AccountType { get; set; }

        public String BranchName { get; set; }

        public String BranchCode { get; set; }
    }
}