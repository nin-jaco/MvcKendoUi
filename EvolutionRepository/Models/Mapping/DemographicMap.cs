using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DemographicMap : EntityTypeConfiguration<Demographic>
    {
        public DemographicMap()
        {
            // Primary Key
            this.HasKey(t => t.DemographicID);

            // Properties
            this.Property(t => t.DemographicID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DemographicName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Demographics");
            this.Property(t => t.DemographicID).HasColumnName("DemographicID");
            this.Property(t => t.DemographicName).HasColumnName("DemographicName");
        }
    }
}
