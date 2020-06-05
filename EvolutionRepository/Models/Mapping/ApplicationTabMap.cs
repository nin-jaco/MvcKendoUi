using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ApplicationTabMap : EntityTypeConfiguration<ApplicationTab>
    {
        public ApplicationTabMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationTabID);

            // Properties
            this.Property(t => t.ApplicationTabID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApplicationTabName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TabKey)
                .HasMaxLength(50);

            this.Property(t => t.TabIcon)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ApplicationTabs");
            this.Property(t => t.ApplicationTabID).HasColumnName("ApplicationTabID");
            this.Property(t => t.ApplicationTabName).HasColumnName("ApplicationTabName");
            this.Property(t => t.TabKey).HasColumnName("TabKey");
            this.Property(t => t.TabIcon).HasColumnName("TabIcon");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
        }
    }
}
