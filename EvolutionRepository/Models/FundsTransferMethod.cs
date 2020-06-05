using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class FundsTransferMethod
    {
        public FundsTransferMethod()
        {
            this.FundsTransferMethodsCertifiedModels = new List<CertifiedModel>();
        }

        public int FundsTransferMethodID { get; set; }
        public string FundsTransferMethodName { get; set; }
        public virtual ICollection<CertifiedModel> FundsTransferMethodsCertifiedModels { get; set; }
    }
}
