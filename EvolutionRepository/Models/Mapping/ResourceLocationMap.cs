using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ResourceLocationMap : EntityTypeConfiguration<ResourceLocation>
    {
        public ResourceLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.ResourceLocationID);

            // Properties
            this.Property(t => t.ResourceLocationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ResourceLocation1)
                .HasMaxLength(50);

            this.Property(t => t.ResourceType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ResourceLocation");
            this.Property(t => t.ResourceLocationID).HasColumnName("ResourceLocationID");
            this.Property(t => t.ResourceLocation1).HasColumnName("ResourceLocation");
            this.Property(t => t.ResourceType).HasColumnName("ResourceType");
        }
    }
}
