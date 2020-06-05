using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class GameThemeMap : EntityTypeConfiguration<GameTheme>
    {
        public GameThemeMap()
        {
            // Primary Key
            this.HasKey(t => t.GameThemeID);

            // Properties
            this.Property(t => t.GameThemeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GameThemeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GameThemes");
            this.Property(t => t.GameThemeID).HasColumnName("GameThemeID");
            this.Property(t => t.GameThemeName).HasColumnName("GameThemeName");
            this.Property(t => t.ManufacturerID).HasColumnName("ManufacturerID");
        }
    }
}
