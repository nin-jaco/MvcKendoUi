using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationTotalMap : EntityTypeConfiguration<OrganisationTotal>
    {
        public OrganisationTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationID, t.FiscalYearID, t.FiscalPeriodID });

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrganisationTotals");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.FiscalYearID).HasColumnName("FiscalYearID");
            this.Property(t => t.FiscalPeriodID).HasColumnName("FiscalPeriodID");
            this.Property(t => t.NoOfMachines).HasColumnName("NoOfMachines");
            this.Property(t => t.NoOfChildren).HasColumnName("NoOfChildren");
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
            this.Property(t => t.OrganisationIndex).HasColumnName("OrganisationIndex");

            // Relationships
            this.HasRequired(t => t.FiscalPeriodsFiscalPeriod)
                .WithMany(t => t.FiscalPeriodsOrganisationTotals)
                .HasForeignKey(d => new { d.FiscalYearID, d.FiscalPeriodID });
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsOrganisationTotals)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
