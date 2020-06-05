using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationSubTypeMap : EntityTypeConfiguration<OrganisationSubType>
    {
        public OrganisationSubTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationSubTypeID, t.OrganisationTypeID });

            // Properties
            this.Property(t => t.OrganisationSubTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationSubTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrganisationSubTypes");
            this.Property(t => t.OrganisationSubTypeID).HasColumnName("OrganisationSubTypeID");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationSubTypeName).HasColumnName("OrganisationSubTypeName");

            // Relationships
            this.HasRequired(t => t.OrganisationTypesOrganisationType)
                .WithMany(t => t.OrganisationTypesOrganisationSubTypes)
                .HasForeignKey(d => d.OrganisationTypeID);

        }
    }
}
