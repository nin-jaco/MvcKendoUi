using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ApprovalStatusMap : EntityTypeConfiguration<ApprovalStatus>
    {
        public ApprovalStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.ApprovalStatusID);

            // Properties
            this.Property(t => t.ApprovalStatusName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ApprovalStatuses");
            this.Property(t => t.ApprovalStatusID).HasColumnName("ApprovalStatusID");
            this.Property(t => t.ApprovalStatusName).HasColumnName("ApprovalStatusName");
        }
    }
}
