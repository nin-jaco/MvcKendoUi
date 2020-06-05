using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class SiteMachineMap : EntityTypeConfiguration<SiteMachine>
    {
        public SiteMachineMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SiteID, t.MachineID });

            // Properties
            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SiteMachines");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.ClusterBoxID).HasColumnName("ClusterBoxID");
            this.Property(t => t.ClusterBoxPort).HasColumnName("ClusterBoxPort");
            this.Property(t => t.Installed).HasColumnName("Installed");

            // Relationships
            this.HasOptional(t => t.RevenueProfilesRevenueProfile)
                .WithMany(t => t.RevenueProfilesSiteMachines)
                .HasForeignKey(d => d.RevenueProfileID);

        }
    }
}
