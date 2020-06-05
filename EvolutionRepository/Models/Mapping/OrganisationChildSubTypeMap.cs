using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationChildSubTypeMap : EntityTypeConfiguration<OrganisationChildSubType>
    {
        public OrganisationChildSubTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationTypeID, t.OrganisationSubTypeID });

            // Properties
            this.Property(t => t.OrganisationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationSubTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrganisationChildSubTypes");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationSubTypeID).HasColumnName("OrganisationSubTypeID");

            // Relationships
            this.HasRequired(t => t.OrganisationTypesOrganisationType)
                .WithMany(t => t.OrganisationTypesOrganisationChildSubTypes)
                .HasForeignKey(d => d.OrganisationTypeID);

        }
    }
}
