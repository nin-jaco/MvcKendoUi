using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class JurisdictionMap : EntityTypeConfiguration<Jurisdiction>
    {
        public JurisdictionMap()
        {
            // Primary Key
            this.HasKey(t => t.JurisdictionID);

            // Properties
            this.Property(t => t.JurisdictionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JurisdictionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Jurisdictions");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.JurisdictionName).HasColumnName("JurisdictionName");
            this.Property(t => t.InPreparation).HasColumnName("InPreparation");
            this.Property(t => t.JurisdictionTypeID).HasColumnName("JurisdictionTypeID");
            this.Property(t => t.JurisdictionParentID).HasColumnName("JurisdictionParentID");

            // Relationships
            this.HasMany(t => t.OrganisationJurisdictionsOrganisations)
                .WithMany(t => t.OrganisationJurisdictionsJurisdictions)
                .Map(m =>
                    {
                        m.ToTable("OrganisationJurisdictions");
                        m.MapLeftKey("JurisdictionID");
                        m.MapRightKey("OrganisationID");
                    });

            this.HasOptional(t => t.JurisdictionTypesJurisdictionType)
                .WithMany(t => t.JurisdictionTypesJurisdictions)
                .HasForeignKey(d => d.JurisdictionTypeID);

        }
    }
}
