using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class InspectionMap : EntityTypeConfiguration<Inspection>
    {
        public InspectionMap()
        {
            // Primary Key
            this.HasKey(t => t.InspectionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Inspections");
            this.Property(t => t.InspectionID).HasColumnName("InspectionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.CreatedByID).HasColumnName("CreatedByID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.InspectionStartDate).HasColumnName("InspectionStartDate");
            this.Property(t => t.InspectionEndDate).HasColumnName("InspectionEndDate");

            // Relationships
            this.HasMany(t => t.SiteInspectionsOrganisations)
                .WithMany(t => t.SiteInspectionsInspections)
                .Map(m =>
                    {
                        m.ToTable("SiteInspections");
                        m.MapLeftKey("InspectionID");
                        m.MapRightKey("SiteID");
                    });


        }
    }
}
