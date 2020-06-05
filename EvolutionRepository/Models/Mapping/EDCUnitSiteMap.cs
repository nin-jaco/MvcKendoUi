using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EDCUnitSiteMap : EntityTypeConfiguration<EDCUnitSite>
    {
        public EDCUnitSiteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.SiteID });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EDCUnitSites");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MasterEDCUnit).HasColumnName("MasterEDCUnit");
            this.Property(t => t.NodeID).HasColumnName("NodeID");

            // Relationships
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsEDCUnitSites)
                .HasForeignKey(d => d.SiteID);

        }
    }
}
