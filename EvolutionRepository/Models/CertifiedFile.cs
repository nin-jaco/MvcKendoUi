using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CertifiedFile
    {
        public CertifiedFile()
        {
            this.CertifiedFilesCertifiedFileHashResults = new List<CertifiedFileHashResult>();
        }

        public int CertifiedModelID { get; set; }
        public string BinaryFileName { get; set; }
        public int BinaryCheckOrder { get; set; }
        public int FileVersion { get; set; }
        public string HashValue { get; set; }
        public virtual ICollection<CertifiedFileHashResult> CertifiedFilesCertifiedFileHashResults { get; set; }
        public virtual CertifiedModel CertifiedModelsCertifiedModel { get; set; }
    }
}
