using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MovementStatuMap : EntityTypeConfiguration<MovementStatu>
    {
        public MovementStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.MovementStatusID);

            // Properties
            this.Property(t => t.MovementStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MovementStatusName)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("MovementStatus");
            this.Property(t => t.MovementStatusID).HasColumnName("MovementStatusID");
            this.Property(t => t.MovementStatusName).HasColumnName("MovementStatusName");
            this.Property(t => t.IsCompleted).HasColumnName("IsCompleted");
        }
    }
}
