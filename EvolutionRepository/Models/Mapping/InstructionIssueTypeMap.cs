using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class InstructionIssueTypeMap : EntityTypeConfiguration<InstructionIssueType>
    {
        public InstructionIssueTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.IssueTypeID);

            // Properties
            this.Property(t => t.IssueTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IssueTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InstructionIssueTypes");
            this.Property(t => t.IssueTypeID).HasColumnName("IssueTypeID");
            this.Property(t => t.IssueTypeName).HasColumnName("IssueTypeName");
        }
    }
}
