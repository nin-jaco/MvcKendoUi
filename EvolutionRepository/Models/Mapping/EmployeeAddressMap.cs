using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EmployeeAddressMap : EntityTypeConfiguration<EmployeeAddress>
    {
        public EmployeeAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.AddressID });

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EmployeeAddresses");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");

            // Relationships
            this.HasRequired(t => t.AddressesAddress)
                .WithMany(t => t.AddressesEmployeeAddresses)
                .HasForeignKey(d => d.AddressID);
            this.HasRequired(t => t.AddressTypesAddressType)
                .WithMany(t => t.AddressTypesEmployeeAddresses)
                .HasForeignKey(d => d.AddressTypeID);
            this.HasRequired(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesEmployeeAddresses)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
