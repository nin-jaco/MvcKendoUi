using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EmployeeTypeMap : EntityTypeConfiguration<EmployeeType>
    {
        public EmployeeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeTypeID);

            // Properties
            this.Property(t => t.EmployeeTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmployeeTypes");
            this.Property(t => t.EmployeeTypeID).HasColumnName("EmployeeTypeID");
            this.Property(t => t.EmployeeTypeName).HasColumnName("EmployeeTypeName");
            this.Property(t => t.IsCalloutEngineer).HasColumnName("IsCalloutEngineer");
            this.Property(t => t.IsServiceEngineer).HasColumnName("IsServiceEngineer");
            this.Property(t => t.IsManager).HasColumnName("IsManager");

            // Relationships
            this.HasMany(t => t.OrganisationEmployeeTypesOrganisationTypes)
                .WithMany(t => t.OrganisationEmployeeTypesEmployeeTypes)
                .Map(m =>
                    {
                        m.ToTable("OrganisationEmployeeTypes");
                        m.MapLeftKey("EmployeeTypeID");
                        m.MapRightKey("OrganisationTypeID");
                    });


        }
    }
}
