using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditMachineDeductionMap : EntityTypeConfiguration<AuditMachineDeduction>
    {
        public AuditMachineDeductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditFiscalYearID, t.AuditFiscalPeriodID, t.AuditMachineID, t.AuditOrganisationID, t.AuditRevenueProfileID, t.AuditCreditOrganisationID });

            // Properties
            this.Property(t => t.AuditFiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditMachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditRevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditRevenueProfileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DeductionTotalTypeName)
                .HasMaxLength(50);

            this.Property(t => t.AuditCreditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AuditMachineDeductions");
            this.Property(t => t.AuditFiscalYearID).HasColumnName("AuditFiscalYearID");
            this.Property(t => t.AuditFiscalPeriodID).HasColumnName("AuditFiscalPeriodID");
            this.Property(t => t.AuditMachineID).HasColumnName("AuditMachineID");
            this.Property(t => t.AuditOrganisationID).HasColumnName("AuditOrganisationID");
            this.Property(t => t.AuditRevenueProfileID).HasColumnName("AuditRevenueProfileID");
            this.Property(t => t.AuditRevenueProfileName).HasColumnName("AuditRevenueProfileName");
            this.Property(t => t.DeductionTotalTypeID).HasColumnName("DeductionTotalTypeID");
            this.Property(t => t.DeductionTotalTypeName).HasColumnName("DeductionTotalTypeName");
            this.Property(t => t.AuditCollectionOrganisationID).HasColumnName("AuditCollectionOrganisationID");
            this.Property(t => t.AuditCreditOrganisationID).HasColumnName("AuditCreditOrganisationID");
            this.Property(t => t.RatePercent).HasColumnName("RatePercent");
            this.Property(t => t.Amount).HasColumnName("Amount");

            // Relationships
            this.HasRequired(t => t.AuditMachineTotalsAuditMachineTotal)
                .WithMany(t => t.AuditMachineTotalsAuditMachineDeductions)
                .HasForeignKey(d => new { d.AuditFiscalYearID, d.AuditFiscalPeriodID, d.AuditMachineID, d.AuditOrganisationID });

        }
    }
}
