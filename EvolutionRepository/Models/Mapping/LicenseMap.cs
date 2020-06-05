using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LicenseMap : EntityTypeConfiguration<License>
    {
        public LicenseMap()
        {
            // Primary Key
            this.HasKey(t => t.LicenseID);

            // Properties
            this.Property(t => t.LicenseNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Licenses");
            this.Property(t => t.LicenseID).HasColumnName("LicenseID");
            this.Property(t => t.LicenseNumber).HasColumnName("LicenseNumber");
            this.Property(t => t.IssuedDate).HasColumnName("IssuedDate");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.LicenseTypeID).HasColumnName("LicenseTypeID");
            this.Property(t => t.LicenseStatusID).HasColumnName("LicenseStatusID");

            // Relationships
            this.HasOptional(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesLicenses)
                .HasForeignKey(d => d.EmployeeID);
            this.HasRequired(t => t.LicenseStatusesLicenseStatus)
                .WithMany(t => t.LicenseStatusesLicenses)
                .HasForeignKey(d => d.LicenseStatusID);
            this.HasRequired(t => t.LicenseTypesLicenseType)
                .WithMany(t => t.LicenseTypesLicenses)
                .HasForeignKey(d => d.LicenseTypeID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsLicenses)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
