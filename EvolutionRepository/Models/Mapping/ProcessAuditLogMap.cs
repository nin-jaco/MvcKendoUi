using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ProcessAuditLogMap : EntityTypeConfiguration<ProcessAuditLog>
    {
        public ProcessAuditLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessAuditID);

            // Properties
            this.Property(t => t.SourceName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.ActionRequired)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ProcessAuditLogs");
            this.Property(t => t.ProcessAuditID).HasColumnName("ProcessAuditID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.SourceName).HasColumnName("SourceName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsInformationOnly).HasColumnName("IsInformationOnly");
            this.Property(t => t.ActionRequired).HasColumnName("ActionRequired");
            this.Property(t => t.ActionPerformedOn).HasColumnName("ActionPerformedOn");
            this.Property(t => t.CEMSUserID).HasColumnName("CEMSUserID");
            this.Property(t => t.ResourceID).HasColumnName("ResourceID");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
        }
    }
}
