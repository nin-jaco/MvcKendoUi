using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Cabinet
    {
        public Cabinet()
        {
            this.CertifiedModelCabinetsCertifiedModels = new List<CertifiedModel>();
        }

        public int CabinetID { get; set; }
        public string CabinetName { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public virtual ICollection<CertifiedModel> CertifiedModelCabinetsCertifiedModels { get; set; }
    }
}
