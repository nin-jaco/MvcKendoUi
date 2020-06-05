using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ApprovalTypeMap : EntityTypeConfiguration<ApprovalType>
    {
        public ApprovalTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ApprovalTypeID);

            // Properties
            this.Property(t => t.ApprovalTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ApprovalTypes");
            this.Property(t => t.ApprovalTypeID).HasColumnName("ApprovalTypeID");
            this.Property(t => t.ApprovalTypeName).HasColumnName("ApprovalTypeName");
        }
    }
}
