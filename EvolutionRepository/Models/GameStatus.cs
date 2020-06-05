using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class GameStatus
    {
        public long MachineID { get; set; }
        public int CertifiedSoftwareID { get; set; }
        public int GameID { get; set; }
        public Nullable<int> RTP { get; set; }
        public byte gameStatus { get; set; }
    }
}
