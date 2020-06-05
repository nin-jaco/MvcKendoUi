using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditFiscalTotalMap : EntityTypeConfiguration<AuditFiscalTotal>
    {
        public AuditFiscalTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditFiscalYearID, t.AuditFiscalPeriodID, t.AuditModelID, t.AuditJurisdictionID, t.AuditSiteID, t.AuditMachineID, t.AuditAreaID, t.AuditAreaManagerID, t.AuditAccountManagerID });

            // Properties
            this.Property(t => t.AuditFiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditJurisdictionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditSiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditMachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditAreaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditAreaManagerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditAccountManagerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModelName)
                .HasMaxLength(50);

            this.Property(t => t.JurisdictionName)
                .HasMaxLength(50);

            this.Property(t => t.SiteName)
                .HasMaxLength(50);

            this.Property(t => t.MachineNumber)
                .HasMaxLength(50);

            this.Property(t => t.AuditAreaName)
                .HasMaxLength(50);

            this.Property(t => t.AuditAreaManagerName)
                .HasMaxLength(50);

            this.Property(t => t.AuditAccountManagerName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AuditFiscalTotals");
            this.Property(t => t.AuditFiscalYearID).HasColumnName("AuditFiscalYearID");
            this.Property(t => t.AuditFiscalPeriodID).HasColumnName("AuditFiscalPeriodID");
            this.Property(t => t.AuditModelID).HasColumnName("AuditModelID");
            this.Property(t => t.AuditJurisdictionID).HasColumnName("AuditJurisdictionID");
            this.Property(t => t.AuditSiteID).HasColumnName("AuditSiteID");
            this.Property(t => t.AuditMachineID).HasColumnName("AuditMachineID");
            this.Property(t => t.AuditAreaID).HasColumnName("AuditAreaID");
            this.Property(t => t.AuditAreaManagerID).HasColumnName("AuditAreaManagerID");
            this.Property(t => t.AuditAccountManagerID).HasColumnName("AuditAccountManagerID");
            this.Property(t => t.ModelName).HasColumnName("ModelName");
            this.Property(t => t.JurisdictionName).HasColumnName("JurisdictionName");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
            this.Property(t => t.MachineNumber).HasColumnName("MachineNumber");
            this.Property(t => t.AuditAreaName).HasColumnName("AuditAreaName");
            this.Property(t => t.AuditAreaManagerName).HasColumnName("AuditAreaManagerName");
            this.Property(t => t.AuditAccountManagerName).HasColumnName("AuditAccountManagerName");
            this.Property(t => t.NoOfCollections).HasColumnName("NoOfCollections");
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
            this.Property(t => t.TotalHandPays).HasColumnName("TotalHandPays");
            this.Property(t => t.TotalDoorOpens).HasColumnName("TotalDoorOpens");
            this.Property(t => t.TotalCashDoorOpens).HasColumnName("TotalCashDoorOpens");
            this.Property(t => t.TotalLogicDoorOpens).HasColumnName("TotalLogicDoorOpens");
            this.Property(t => t.TotalCallAttendants).HasColumnName("TotalCallAttendants");
            this.Property(t => t.TotalProgressiveWin).HasColumnName("TotalProgressiveWin");
            this.Property(t => t.DoubleUpIn).HasColumnName("DoubleUpIn");
            this.Property(t => t.DoubleUpOut).HasColumnName("DoubleUpOut");
            this.Property(t => t.RemoteCashIn).HasColumnName("RemoteCashIn");
            this.Property(t => t.RemoteCashOut).HasColumnName("RemoteCashOut");
            this.Property(t => t.GrossGamingRevenue).HasColumnName("GrossGamingRevenue");
            this.Property(t => t.NettGamingRevenue).HasColumnName("NettGamingRevenue");
            this.Property(t => t.DownTimeHours).HasColumnName("DownTimeHours");
            this.Property(t => t.SiteIndex).HasColumnName("SiteIndex");
            this.Property(t => t.MachineIndex).HasColumnName("MachineIndex");

            // Relationships
            this.HasRequired(t => t.AuditMachineTotalsAuditMachineTotal)
                .WithMany(t => t.AuditMachineTotalsAuditFiscalTotals)
                .HasForeignKey(d => new { d.AuditFiscalYearID, d.AuditFiscalPeriodID, d.AuditMachineID, d.AuditSiteID });

        }
    }
}
