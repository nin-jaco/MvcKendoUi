using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationStatuMap : EntityTypeConfiguration<OrganisationStatu>
    {
        public OrganisationStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganisationStatusID);

            // Properties
            this.Property(t => t.OrganisationStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationStatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrganisationStatus");
            this.Property(t => t.OrganisationStatusID).HasColumnName("OrganisationStatusID");
            this.Property(t => t.OrganisationStatusName).HasColumnName("OrganisationStatusName");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
        }
    }
}
