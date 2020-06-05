using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DenominationTypeMap : EntityTypeConfiguration<DenominationType>
    {
        public DenominationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DenominationTypeID);

            // Properties
            this.Property(t => t.DenominationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DenominationTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DenominationTypes");
            this.Property(t => t.DenominationTypeID).HasColumnName("DenominationTypeID");
            this.Property(t => t.DenominationTypeName).HasColumnName("DenominationTypeName");
        }
    }
}
