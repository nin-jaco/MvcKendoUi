using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditOrganisationInvoiceMap : EntityTypeConfiguration<AuditOrganisationInvoice>
    {
        public AuditOrganisationInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditOrganisationID, t.AuditFiscalYearID, t.AuditFiscalPeriodID, t.FiscalYearName });

            // Properties
            this.Property(t => t.AuditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalYearName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.FiscalPeriodName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Invoice)
                .IsRequired()
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("AuditOrganisationInvoices");
            this.Property(t => t.AuditOrganisationID).HasColumnName("AuditOrganisationID");
            this.Property(t => t.AuditFiscalYearID).HasColumnName("AuditFiscalYearID");
            this.Property(t => t.AuditFiscalPeriodID).HasColumnName("AuditFiscalPeriodID");
            this.Property(t => t.FiscalYearName).HasColumnName("FiscalYearName");
            this.Property(t => t.FiscalPeriodName).HasColumnName("FiscalPeriodName");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Invoice).HasColumnName("Invoice");
        }
    }
}
