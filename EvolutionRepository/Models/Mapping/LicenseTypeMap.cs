using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LicenseTypeMap : EntityTypeConfiguration<LicenseType>
    {
        public LicenseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.LicenseTypeID);

            // Properties
            this.Property(t => t.LicenseTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LicenseTypes");
            this.Property(t => t.LicenseTypeID).HasColumnName("LicenseTypeID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.LicenseTypeName).HasColumnName("LicenseTypeName");
            this.Property(t => t.LicenseFee).HasColumnName("LicenseFee");
            this.Property(t => t.LicenseMonths).HasColumnName("LicenseMonths");
            this.Property(t => t.EntityTypeID).HasColumnName("EntityTypeID");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");

            // Relationships
            this.HasRequired(t => t.EntityTypesEntityType)
                .WithMany(t => t.EntityTypesLicenseTypes)
                .HasForeignKey(d => d.EntityTypeID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsLicenseTypes)
                .HasForeignKey(d => d.OrganisationID);
            this.HasRequired(t => t.OrganisationTypesOrganisationType)
                .WithMany(t => t.OrganisationTypesLicenseTypes)
                .HasForeignKey(d => d.EntityTypeID);

        }
    }
}
