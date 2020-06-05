using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineDeductionMap : EntityTypeConfiguration<MachineDeduction>
    {
        public MachineDeductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FiscalYearID, t.FiscalPeriodID, t.MachineID, t.SiteID, t.RevenueProfileID, t.CreditOrganisationID });

            // Properties
            this.Property(t => t.FiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MachineDeductions");
            this.Property(t => t.FiscalYearID).HasColumnName("FiscalYearID");
            this.Property(t => t.FiscalPeriodID).HasColumnName("FiscalPeriodID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.CollectionOrganisationID).HasColumnName("CollectionOrganisationID");
            this.Property(t => t.CreditOrganisationID).HasColumnName("CreditOrganisationID");
            this.Property(t => t.RatePercent).HasColumnName("RatePercent");
            this.Property(t => t.Amount).HasColumnName("Amount");

            // Relationships
            this.HasRequired(t => t.MachineTotalsMachineTotal)
                .WithMany(t => t.MachineTotalsMachineDeductions)
                .HasForeignKey(d => new { d.FiscalYearID, d.FiscalPeriodID, d.MachineID, d.SiteID });

        }
    }
}
