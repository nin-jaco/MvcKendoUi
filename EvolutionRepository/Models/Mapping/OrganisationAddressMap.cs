using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationAddressMap : EntityTypeConfiguration<OrganisationAddress>
    {
        public OrganisationAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationID, t.AddressID });

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrganisationAddresses");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");

            // Relationships
            this.HasRequired(t => t.AddressesAddress)
                .WithMany(t => t.AddressesOrganisationAddresses)
                .HasForeignKey(d => d.AddressID);
            this.HasRequired(t => t.AddressTypesAddressType)
                .WithMany(t => t.AddressTypesOrganisationAddresses)
                .HasForeignKey(d => d.AddressTypeID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsOrganisationAddresses)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
