using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditFiscalPeriodMap : EntityTypeConfiguration<AuditFiscalPeriod>
    {
        public AuditFiscalPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditFiscalYearID, t.AuditFiscalPeriodID });

            // Properties
            this.Property(t => t.AuditFiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalYearName)
                .HasMaxLength(255);

            this.Property(t => t.FiscalPeriodName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AuditFiscalPeriods");
            this.Property(t => t.AuditOrganisationID).HasColumnName("AuditOrganisationID");
            this.Property(t => t.AuditFiscalYearID).HasColumnName("AuditFiscalYearID");
            this.Property(t => t.AuditFiscalPeriodID).HasColumnName("AuditFiscalPeriodID");
            this.Property(t => t.FiscalYearName).HasColumnName("FiscalYearName");
            this.Property(t => t.FiscalPeriodName).HasColumnName("FiscalPeriodName");
            this.Property(t => t.AuditFiscalPeriodTypeID).HasColumnName("AuditFiscalPeriodTypeID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DateProcessed).HasColumnName("DateProcessed");
            this.Property(t => t.AuditDateProcessed).HasColumnName("AuditDateProcessed");

            // Relationships
            this.HasOptional(t => t.AuditFiscalPeriodTypesAuditFiscalPeriodType)
                .WithMany(t => t.AuditFiscalPeriodTypesAuditFiscalPeriods)
                .HasForeignKey(d => d.AuditFiscalPeriodTypeID);
            this.HasRequired(t => t.FiscalPeriodsFiscalPeriod)
                .WithOptional(t => t.FiscalPeriodsAuditFiscalPeriod);

        }
    }
}
