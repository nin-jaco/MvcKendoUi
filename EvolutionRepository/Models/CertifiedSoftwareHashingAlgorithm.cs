using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CertifiedSoftwareHashingAlgorithm
    {
        public CertifiedSoftwareHashingAlgorithm()
        {
            this.CertifiedSoftwareHashingAlgorithmsCertifiedModels = new List<CertifiedModel>();
            this.CertifiedSoftwareHashingAlgorithms1CertifiedModels = new List<CertifiedModel>();
        }

        public int CertifiedSoftwareHashingAlgorithmID { get; set; }
        public string CertifiedSoftwareHashingAlgorithmName { get; set; }
        public virtual ICollection<CertifiedModel> CertifiedSoftwareHashingAlgorithmsCertifiedModels { get; set; }
        public virtual ICollection<CertifiedModel> CertifiedSoftwareHashingAlgorithms1CertifiedModels { get; set; }
    }
}
