using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ApplicationTabSubTypeMap : EntityTypeConfiguration<ApplicationTabSubType>
    {
        public ApplicationTabSubTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationTypeID, t.OrganisationSubTypeID, t.ApplicationTabID });

            // Properties
            this.Property(t => t.OrganisationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationSubTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApplicationTabID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ApplicationTabSubTypes");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationSubTypeID).HasColumnName("OrganisationSubTypeID");
            this.Property(t => t.ApplicationTabID).HasColumnName("ApplicationTabID");
        }
    }
}
