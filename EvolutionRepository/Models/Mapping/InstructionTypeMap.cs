using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class InstructionTypeMap : EntityTypeConfiguration<InstructionType>
    {
        public InstructionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.InstructionTypeID);

            // Properties
            this.Property(t => t.InstructionTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InstructionName)
                .HasMaxLength(50);

            this.Property(t => t.SubInstructionType)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("InstructionTypes");
            this.Property(t => t.InstructionTypeID).HasColumnName("InstructionTypeID");
            this.Property(t => t.InstructionName).HasColumnName("InstructionName");
            this.Property(t => t.SubInstructionType).HasColumnName("SubInstructionType");
        }
    }
}
