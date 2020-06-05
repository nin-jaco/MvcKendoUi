using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditDailyCollectionMap : EntityTypeConfiguration<AuditDailyCollection>
    {
        public AuditDailyCollectionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplicableDate, t.AuditSiteID, t.AuditMachineID, t.AuditRevenueProfileID });

            // Properties
            this.Property(t => t.AuditSiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditMachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditRevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AuditDailyCollections");
            this.Property(t => t.ApplicableDate).HasColumnName("ApplicableDate");
            this.Property(t => t.AuditSiteID).HasColumnName("AuditSiteID");
            this.Property(t => t.AuditMachineID).HasColumnName("AuditMachineID");
            this.Property(t => t.AuditRevenueProfileID).HasColumnName("AuditRevenueProfileID");
            this.Property(t => t.AuditJurisdictionID).HasColumnName("AuditJurisdictionID");
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
            this.Property(t => t.Downtime).HasColumnName("Downtime");
            this.Property(t => t.GrossGamingRevenue).HasColumnName("GrossGamingRevenue");
            this.Property(t => t.NettGamingRevenue).HasColumnName("NettGamingRevenue");

            // Relationships
            this.HasRequired(t => t.DailyCollectionsDailyCollection)
                .WithOptional(t => t.DailyCollectionsAuditDailyCollection);

        }
    }
}
