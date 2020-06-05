using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CertifiedGame
    {
        public int CertifiedModelID { get; set; }
        public int CertifiedGameID { get; set; }
        public string CertifiedGameName { get; set; }
        public int PlayerDenom { get; set; }
        public int MinimumBet { get; set; }
        public int MaximumBet { get; set; }
        public int MinimumRTP { get; set; }
        public int MaximumRTP { get; set; }
        public virtual CertifiedModel CertifiedModelsCertifiedModel { get; set; }
    }
}
