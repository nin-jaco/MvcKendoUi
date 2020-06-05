using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditDailyDeductionMap : EntityTypeConfiguration<AuditDailyDeduction>
    {
        public AuditDailyDeductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditMachineID, t.ApplicableDate, t.RevenueProfileID, t.AuditSiteID, t.AuditCreditOrganisationID });

            // Properties
            this.Property(t => t.AuditMachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditSiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DeductionTotalTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuditCreditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AuditDailyDeductions");
            this.Property(t => t.AuditMachineID).HasColumnName("AuditMachineID");
            this.Property(t => t.ApplicableDate).HasColumnName("ApplicableDate");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.AuditSiteID).HasColumnName("AuditSiteID");
            this.Property(t => t.RevenueProfileName).HasColumnName("RevenueProfileName");
            this.Property(t => t.DeductionTotalTypeID).HasColumnName("DeductionTotalTypeID");
            this.Property(t => t.DeductionTotalTypeName).HasColumnName("DeductionTotalTypeName");
            this.Property(t => t.AuditCollectionOrganisationID).HasColumnName("AuditCollectionOrganisationID");
            this.Property(t => t.AuditCreditOrganisationID).HasColumnName("AuditCreditOrganisationID");
            this.Property(t => t.RatePercent).HasColumnName("RatePercent");
            this.Property(t => t.Amount).HasColumnName("Amount");
        }
    }
}
