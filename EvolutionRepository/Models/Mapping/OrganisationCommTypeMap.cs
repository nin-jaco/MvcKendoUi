using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationCommTypeMap : EntityTypeConfiguration<OrganisationCommType>
    {
        public OrganisationCommTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganisationCommTypeID);

            // Properties
            this.Property(t => t.OrganisationCommTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationCommTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrganisationCommTypes");
            this.Property(t => t.OrganisationCommTypeID).HasColumnName("OrganisationCommTypeID");
            this.Property(t => t.OrganisationCommTypeName).HasColumnName("OrganisationCommTypeName");
        }
    }
}
