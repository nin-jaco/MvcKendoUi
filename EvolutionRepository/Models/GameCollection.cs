using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class GameCollection
    {
        public long MachineID { get; set; }
        public int SiteID { get; set; }
        public int CertifiedModelID { get; set; }
        public int GameID { get; set; }
        public System.DateTime CollectionStartTime { get; set; }
        public System.DateTime CollectionEndTime { get; set; }
        public int GMGameType { get; set; }
        public int PlayerDenom { get; set; }
        public int CurrentRTP { get; set; }
        public int TotalBet { get; set; }
        public int TotalWin { get; set; }
        public int TotalGamesPlayed { get; set; }
        public Nullable<int> TotalGamesWon { get; set; }
        public Nullable<int> MaximumBet { get; set; }
        public Nullable<int> MaximumWin { get; set; }
        public Nullable<System.DateTime> DateMigrated { get; set; }
    }
}
