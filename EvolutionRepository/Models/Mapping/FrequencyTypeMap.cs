using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class FrequencyTypeMap : EntityTypeConfiguration<FrequencyType>
    {
        public FrequencyTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.FrequencyTypeID);

            // Properties
            this.Property(t => t.FrequencyTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FrequencyName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FrequencyType");
            this.Property(t => t.FrequencyTypeID).HasColumnName("FrequencyTypeID");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
        }
    }
}
