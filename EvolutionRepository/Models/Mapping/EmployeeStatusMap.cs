using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EmployeeStatusMap : EntityTypeConfiguration<EmployeeStatus>
    {
        public EmployeeStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeStatusID);

            // Properties
            this.Property(t => t.EmployeeStatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmployeeStatuses");
            this.Property(t => t.EmployeeStatusID).HasColumnName("EmployeeStatusID");
            this.Property(t => t.EmployeeStatusName).HasColumnName("EmployeeStatusName");
        }
    }
}
