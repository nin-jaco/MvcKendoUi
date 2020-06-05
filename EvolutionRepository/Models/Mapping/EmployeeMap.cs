using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdentificationNumber)
                .HasMaxLength(50);

            this.Property(t => t.HomePhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.EmergencyContactName)
                .HasMaxLength(50);

            this.Property(t => t.EmergencyContactPhone)
                .HasMaxLength(20);

            this.Property(t => t.TrainingComments)
                .HasMaxLength(1024);

            this.Property(t => t.Comments)
                .HasMaxLength(1024);

            this.Property(t => t.MobilePhone)
                .HasMaxLength(15);

            this.Property(t => t.Timestamp)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.EmployeeTypeID).HasColumnName("EmployeeTypeID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.TitleID).HasColumnName("TitleID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.IdentificationNumber).HasColumnName("IdentificationNumber");
            this.Property(t => t.HomePhone).HasColumnName("HomePhone");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.DateHired).HasColumnName("DateHired");
            this.Property(t => t.EmergencyContactName).HasColumnName("EmergencyContactName");
            this.Property(t => t.EmergencyContactPhone).HasColumnName("EmergencyContactPhone");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.TrainingComments).HasColumnName("TrainingComments");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.EmployeeStatusID).HasColumnName("EmployeeStatusID");

            // Relationships
            this.HasOptional(t => t.DepartmentsDepartment)
                .WithMany(t => t.DepartmentsEmployees)
                .HasForeignKey(d => d.DepartmentID);
            this.HasOptional(t => t.EmployeeStatusesEmployeeStatus)
                .WithMany(t => t.EmployeeStatusesEmployees)
                .HasForeignKey(d => d.EmployeeStatusID);
            this.HasRequired(t => t.EmployeeType)
                .WithMany(t => t.EmployeeTypeEmployees)
                .HasForeignKey(d => d.EmployeeTypeID);
            this.HasRequired(t => t.TitlesTitle)
                .WithMany(t => t.TitlesEmployees)
                .HasForeignKey(d => d.TitleID);

        }
    }
}
