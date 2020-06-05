using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CertifiedFileHashResult
    {
        public int CertifiedModelID { get; set; }
        public string BinaryFileName { get; set; }
        public string Seed { get; set; }
        public string Result { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public virtual CertifiedFile CertifiedFilesCertifiedFile { get; set; }
    }
}
