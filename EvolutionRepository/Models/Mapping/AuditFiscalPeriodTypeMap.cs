using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditFiscalPeriodTypeMap : EntityTypeConfiguration<AuditFiscalPeriodType>
    {
        public AuditFiscalPeriodTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditFiscalPeriodTypeID);

            // Properties
            this.Property(t => t.AuditFiscalPeriodTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalPeriodTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AuditFiscalPeriodTypes");
            this.Property(t => t.AuditFiscalPeriodTypeID).HasColumnName("AuditFiscalPeriodTypeID");
            this.Property(t => t.AuditFiscalPeriodTypeName).HasColumnName("AuditFiscalPeriodTypeName");
        }
    }
}
