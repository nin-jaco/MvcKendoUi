using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationTypeCardTypeMap : EntityTypeConfiguration<OrganisationTypeCardType>
    {
        public OrganisationTypeCardTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JurisdictionID, t.OrganisationTypeID, t.CardTypeID });

            // Properties
            this.Property(t => t.JurisdictionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrganisationTypeCardTypes");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.CardTypeID).HasColumnName("CardTypeID");
            this.Property(t => t.RequiredLicenseTypeID).HasColumnName("RequiredLicenseTypeID");
        }
    }
}
