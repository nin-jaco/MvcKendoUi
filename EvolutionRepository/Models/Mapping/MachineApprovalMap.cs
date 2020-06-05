using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineApprovalMap : EntityTypeConfiguration<MachineApproval>
    {
        public MachineApprovalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApprovalID, t.MachineID });

            // Properties
            this.Property(t => t.ApprovalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MachineApprovals");
            this.Property(t => t.ApprovalID).HasColumnName("ApprovalID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");

            // Relationships
            this.HasRequired(t => t.ApprovalsApproval)
                .WithMany(t => t.ApprovalsMachineApprovals)
                .HasForeignKey(d => d.ApprovalID);

        }
    }
}
