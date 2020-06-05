using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DeductionTypeMap : EntityTypeConfiguration<DeductionType>
    {
        public DeductionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DeductionTypeID);

            // Properties
            this.Property(t => t.DeductionTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeductionTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DeductionTypes");
            this.Property(t => t.DeductionTypeID).HasColumnName("DeductionTypeID");
            this.Property(t => t.DeductionTypeName).HasColumnName("DeductionTypeName");
        }
    }
}
