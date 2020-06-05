using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class GameStatusesMap : EntityTypeConfiguration<GameStatuses>
    {
        public GameStatusesMap()
        {
            // Primary Key
            this.HasKey(t => t.GameStatusID);

            // Properties
            this.Property(t => t.GameStatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GameStatuses");
            this.Property(t => t.GameStatusID).HasColumnName("GameStatusID");
            this.Property(t => t.GameStatusName).HasColumnName("GameStatusName");
        }
    }
}
