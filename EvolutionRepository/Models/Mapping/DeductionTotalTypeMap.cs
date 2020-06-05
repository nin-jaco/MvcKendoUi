using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DeductionTotalTypeMap : EntityTypeConfiguration<DeductionTotalType>
    {
        public DeductionTotalTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DeductionTotalTypeID);

            // Properties
            this.Property(t => t.DeductionTotalTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeductionTotalTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DeductionTotalTypes");
            this.Property(t => t.DeductionTotalTypeID).HasColumnName("DeductionTotalTypeID");
            this.Property(t => t.DeductionTotalTypeName).HasColumnName("DeductionTotalTypeName");
        }
    }
}
