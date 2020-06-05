using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class systemsettingMap : EntityTypeConfiguration<systemsetting>
    {
        public systemsettingMap()
        {
            // Primary Key
            this.HasKey(t => t.Variable);

            // Properties
            this.Property(t => t.Variable)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("systemsettings");
            this.Property(t => t.Variable).HasColumnName("Variable");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
