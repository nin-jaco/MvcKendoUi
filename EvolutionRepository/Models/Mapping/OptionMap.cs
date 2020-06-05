using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OptionMap : EntityTypeConfiguration<Option>
    {
        public OptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ModuleID, t.OptionID });

            // Properties
            this.Property(t => t.ModuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OptionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OptionName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OptionType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DefaultValue)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Options");
            this.Property(t => t.ModuleID).HasColumnName("ModuleID");
            this.Property(t => t.OptionID).HasColumnName("OptionID");
            this.Property(t => t.OptionName).HasColumnName("OptionName");
            this.Property(t => t.OptionType).HasColumnName("OptionType");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.OptionIntData).HasColumnName("OptionIntData");

            // Relationships
            this.HasRequired(t => t.ModulesModule)
                .WithMany(t => t.ModulesOptions)
                .HasForeignKey(d => d.ModuleID);

        }
    }
}
