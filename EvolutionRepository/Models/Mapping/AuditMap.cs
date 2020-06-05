using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditMap : EntityTypeConfiguration<Audit>
    {
        public AuditMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditID);

            // Properties
            this.Property(t => t.AuditType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OldValue)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.NewValue)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.IPAddress)
                .HasMaxLength(100);

            this.Property(t => t.UserAgentString)
                .HasMaxLength(400);

            this.Property(t => t.ChangeByUserID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ChangeByFullName)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Audit");
            this.Property(t => t.AuditID).HasColumnName("AuditID");
            this.Property(t => t.AuditType).HasColumnName("AuditType");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
            this.Property(t => t.OldValue).HasColumnName("OldValue");
            this.Property(t => t.NewValue).HasColumnName("NewValue");
            this.Property(t => t.IPAddress).HasColumnName("IPAddress");
            this.Property(t => t.UserAgentString).HasColumnName("UserAgentString");
            this.Property(t => t.ChangeByUserID).HasColumnName("ChangeByUserID");
            this.Property(t => t.ChangeByFullName).HasColumnName("ChangeByFullName");
        }
    }
}
