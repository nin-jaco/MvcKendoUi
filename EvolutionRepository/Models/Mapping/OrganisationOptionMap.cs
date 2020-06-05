using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationOptionMap : EntityTypeConfiguration<OrganisationOption>
    {
        public OrganisationOptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationID, t.ModuleID, t.OptionID });

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OptionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("OrganisationOptions");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.ModuleID).HasColumnName("ModuleID");
            this.Property(t => t.OptionID).HasColumnName("OptionID");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.OptionsOption)
                .WithMany(t => t.OptionsOrganisationOptions)
                .HasForeignKey(d => new { d.ModuleID, d.OptionID });
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsOrganisationOptions)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
