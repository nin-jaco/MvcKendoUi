using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class SiteVisitMap : EntityTypeConfiguration<SiteVisit>
    {
        public SiteVisitMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteVisitID);

            // Properties
            this.Property(t => t.Comments)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("SiteVisits");
            this.Property(t => t.SiteVisitID).HasColumnName("SiteVisitID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.ArrivalTime).HasColumnName("ArrivalTime");
            this.Property(t => t.DepartureTime).HasColumnName("DepartureTime");
            this.Property(t => t.Comments).HasColumnName("Comments");

            // Relationships
            this.HasRequired(t => t.SitesSite)
                .WithMany(t => t.SitesSiteVisits)
                .HasForeignKey(d => d.SiteID);

        }
    }
}
