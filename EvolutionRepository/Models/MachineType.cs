using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineType
    {
        public MachineType()
        {
            this.MachineTypesCertifiedModels = new List<CertifiedModel>();
        }

        public int MachineTypeID { get; set; }
        public string MachineTypeName { get; set; }
        public bool IsEDC { get; set; }
        public Nullable<bool> IsAssetManaged { get; set; }
        public virtual ICollection<CertifiedModel> MachineTypesCertifiedModels { get; set; }
    }
}
