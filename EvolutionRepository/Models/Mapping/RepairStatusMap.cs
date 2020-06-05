using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class RepairStatusMap : EntityTypeConfiguration<RepairStatus>
    {
        public RepairStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.RepairStatusID);

            // Properties
            this.Property(t => t.RepairStatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RepairStatuses");
            this.Property(t => t.RepairStatusID).HasColumnName("RepairStatusID");
            this.Property(t => t.RepairStatusName).HasColumnName("RepairStatusName");
        }
    }
}
