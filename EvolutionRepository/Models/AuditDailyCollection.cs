using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class AuditDailyCollection
    {
        public System.DateTime ApplicableDate { get; set; }
        public int AuditSiteID { get; set; }
        public int AuditMachineID { get; set; }
        public int AuditRevenueProfileID { get; set; }
        public int AuditJurisdictionID { get; set; }
        public decimal TotalCoinsIn { get; set; }
        public decimal TotalCoinboxDrop { get; set; }
        public decimal TotalCoinRefill { get; set; }
        public decimal TotalCoinsOut { get; set; }
        public decimal TotalCoinDump { get; set; }
        public decimal TotalNotesIn { get; set; }
        public decimal TotalCashIn { get; set; }
        public decimal TotalCashOut { get; set; }
        public decimal TotalCashlessIn { get; set; }
        public decimal TotalCashlessOut { get; set; }
        public decimal TotalBet { get; set; }
        public decimal TotalWin { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalResets { get; set; }
        public int TotalGamesSinceReset { get; set; }
        public decimal TotalHandPays { get; set; }
        public int TotalDoorOpens { get; set; }
        public int TotalCashDoorOpens { get; set; }
        public int TotalLogicDoorOpens { get; set; }
        public int GamesSinceDoorClosed { get; set; }
        public int TotalCallAttendants { get; set; }
        public decimal LastProgressiveWin { get; set; }
        public decimal TotalProgressiveWin { get; set; }
        public decimal DoubleUpIn { get; set; }
        public decimal DoubleUpOut { get; set; }
        public decimal RemoteCashIn { get; set; }
        public decimal RemoteCashOut { get; set; }
        public Nullable<double> Downtime { get; set; }
        public decimal GrossGamingRevenue { get; set; }
        public decimal NettGamingRevenue { get; set; }
        public virtual DailyCollection DailyCollectionsDailyCollection { get; set; }
    }
}
