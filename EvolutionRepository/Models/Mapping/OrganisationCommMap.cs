using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationCommMap : EntityTypeConfiguration<OrganisationComm>
    {
        public OrganisationCommMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganisationCommID);

            // Properties
            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AddressPrefix)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrganisationComms");
            this.Property(t => t.OrganisationCommID).HasColumnName("OrganisationCommID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.OrganisationCommTypeID).HasColumnName("OrganisationCommTypeID");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.AddressPrefix).HasColumnName("AddressPrefix");
            this.Property(t => t.CommsHoneymoon).HasColumnName("CommsHoneymoon");

            // Relationships
            this.HasRequired(t => t.OrganisationCommTypesOrganisationCommType)
                .WithMany(t => t.OrganisationCommTypesOrganisationComms)
                .HasForeignKey(d => d.OrganisationCommTypeID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsOrganisationComms)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
