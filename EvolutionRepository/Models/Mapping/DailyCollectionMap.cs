using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DailyCollectionMap : EntityTypeConfiguration<DailyCollection>
    {
        public DailyCollectionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.SiteID, t.RevenueProfileID, t.ApplicableDate });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DailyCollections");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.CollectionEndTime).HasColumnName("CollectionEndTime");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.ApplicableDate).HasColumnName("ApplicableDate");
            this.Property(t => t.TotalCoinsIn).HasColumnName("TotalCoinsIn");
            this.Property(t => t.TotalCoinboxDrop).HasColumnName("TotalCoinboxDrop");
            this.Property(t => t.TotalCoinRefill).HasColumnName("TotalCoinRefill");
            this.Property(t => t.TotalCoinsOut).HasColumnName("TotalCoinsOut");
            this.Property(t => t.TotalCoinDump).HasColumnName("TotalCoinDump");
            this.Property(t => t.TotalNotesIn).HasColumnName("TotalNotesIn");
            this.Property(t => t.TotalCashIn).HasColumnName("TotalCashIn");
            this.Property(t => t.TotalCashOut).HasColumnName("TotalCashOut");
            this.Property(t => t.TotalCashlessIn).HasColumnName("TotalCashlessIn");
            this.Property(t => t.TotalCashlessOut).HasColumnName("TotalCashlessOut");
            this.Property(t => t.TotalBet).HasColumnName("TotalBet");
            this.Property(t => t.TotalWin).HasColumnName("TotalWin");
            this.Property(t => t.TotalGamesPlayed).HasColumnName("TotalGamesPlayed");
            this.Property(t => t.TotalResets).HasColumnName("TotalResets");
            this.Property(t => t.TotalGamesSinceReset).HasColumnName("TotalGamesSinceReset");
            this.Property(t => t.TotalHandPays).HasColumnName("TotalHandPays");
            this.Property(t => t.TotalDoorOpens).HasColumnName("TotalDoorOpens");
            this.Property(t => t.TotalCashDoorOpens).HasColumnName("TotalCashDoorOpens");
            this.Property(t => t.TotalLogicDoorOpens).HasColumnName("TotalLogicDoorOpens");
            this.Property(t => t.GamesSinceDoorClosed).HasColumnName("GamesSinceDoorClosed");
            this.Property(t => t.TotalCallAttendants).HasColumnName("TotalCallAttendants");
            this.Property(t => t.LastProgressiveWin).HasColumnName("LastProgressiveWin");
            this.Property(t => t.TotalProgressiveWin).HasColumnName("TotalProgressiveWin");
            this.Property(t => t.DoubleUpIn).HasColumnName("DoubleUpIn");
            this.Property(t => t.DoubleUpOut).HasColumnName("DoubleUpOut");
            this.Property(t => t.RemoteCashIn).HasColumnName("RemoteCashIn");
            this.Property(t => t.RemoteCashOut).HasColumnName("RemoteCashOut");
            this.Property(t => t.GrossGamingRevenue).HasColumnName("GrossGamingRevenue");
            this.Property(t => t.NettGamingRevenue).HasColumnName("NettGamingRevenue");
            this.Property(t => t.DownTime).HasColumnName("DownTime");
            this.Property(t => t.DeductionsCalculated).HasColumnName("DeductionsCalculated");
            this.Property(t => t.SharesCalculated).HasColumnName("SharesCalculated");
        }
    }
}
