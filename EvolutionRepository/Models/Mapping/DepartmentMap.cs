using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmentID);

            // Properties
            this.Property(t => t.DepartmentName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Departments");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.DepartmentName).HasColumnName("DepartmentName");
            this.Property(t => t.DepartmentParentID).HasColumnName("DepartmentParentID");

            // Relationships
            this.HasOptional(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsDepartments)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
