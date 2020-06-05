using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrgTreeMap : EntityTypeConfiguration<OrgTree>
    {
        public OrgTreeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TopOrganisationID, t.OrganisationID });

            // Properties
            this.Property(t => t.TopOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationName)
                .HasMaxLength(50);

            this.Property(t => t.ContactName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrgTree");
            this.Property(t => t.TopOrganisationID).HasColumnName("TopOrganisationID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.OrganisationName).HasColumnName("OrganisationName");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationSubTypeID).HasColumnName("OrganisationSubTypeID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.OrganisationStatusID).HasColumnName("OrganisationStatusID");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
        }
    }
}
