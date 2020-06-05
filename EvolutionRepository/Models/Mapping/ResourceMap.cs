using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ResourceMap : EntityTypeConfiguration<Resource>
    {
        public ResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ResourceID);

            // Properties
            this.Property(t => t.ResourceName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DisplayName)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(1500);

            this.Property(t => t.Controller)
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Resources");
            this.Property(t => t.ResourceID).HasColumnName("ResourceID");
            this.Property(t => t.ResourceName).HasColumnName("ResourceName");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.IsDialogAdd).HasColumnName("IsDialogAdd");
            this.Property(t => t.IsDialogList).HasColumnName("IsDialogList");
            this.Property(t => t.IsMenuItem).HasColumnName("IsMenuItem");
            this.Property(t => t.IsBrowserPage).HasColumnName("IsBrowserPage");
            this.Property(t => t.ResourceLocationID).HasColumnName("ResourceLocationID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
        }
    }
}
