using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaID);

            // Properties
            this.Property(t => t.AreaName)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Telephone)
                .HasMaxLength(15);

            this.Property(t => t.EmergencyNumber)
                .HasMaxLength(15);

            this.Property(t => t.Mobile)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Areas");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.EmergencyNumber).HasColumnName("EmergencyNumber");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Total_staff_Allocted).HasColumnName("Total_staff_Allocted");
            this.Property(t => t.Total_Engineers_Allocated).HasColumnName("Total_Engineers_Allocated");
            this.Property(t => t.Total_Vehicles_Allocated).HasColumnName("Total_Vehicles_Allocated");

            // Relationships
            this.HasMany(t => t.OrganisationAreasOrganisations)
                .WithMany(t => t.OrganisationAreasAreas)
                .Map(m =>
                    {
                        m.ToTable("OrganisationAreas");
                        m.MapLeftKey("AreaID");
                        m.MapRightKey("OrganisationID");
                    });

            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsAreas)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
