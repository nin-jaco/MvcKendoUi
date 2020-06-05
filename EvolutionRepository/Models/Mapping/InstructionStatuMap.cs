using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class InstructionStatuMap : EntityTypeConfiguration<InstructionStatu>
    {
        public InstructionStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.InstructionStatusID);

            // Properties
            this.Property(t => t.InstructionStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InstructionStatusName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InstructionStatus");
            this.Property(t => t.InstructionStatusID).HasColumnName("InstructionStatusID");
            this.Property(t => t.InstructionStatusName).HasColumnName("InstructionStatusName");
        }
    }
}
