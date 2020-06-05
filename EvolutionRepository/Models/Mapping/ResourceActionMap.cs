using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ResourceActionMap : EntityTypeConfiguration<ResourceAction>
    {
        public ResourceActionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ResourceID, t.ActionID });

            // Properties
            this.Property(t => t.ResourceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ResourceActions");
            this.Property(t => t.ResourceID).HasColumnName("ResourceID");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.IsAuditable).HasColumnName("IsAuditable");

            // Relationships
            this.HasRequired(t => t.ActionsAction)
                .WithMany(t => t.ActionsResourceActions)
                .HasForeignKey(d => d.ActionID);
            this.HasRequired(t => t.ResourcesResource)
                .WithMany(t => t.ResourcesResourceActions)
                .HasForeignKey(d => d.ResourceID);

        }
    }
}
