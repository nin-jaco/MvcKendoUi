using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Previous10Passwords)
                .HasMaxLength(640);

            this.Property(t => t.TimeStamp)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.AccessRightsGranted).HasColumnName("AccessRightsGranted");
            this.Property(t => t.PasswordLife).HasColumnName("PasswordLife");
            this.Property(t => t.DateOfLastPasswordChange).HasColumnName("DateOfLastPasswordChange");
            this.Property(t => t.AutomaticPassword).HasColumnName("AutomaticPassword");
            this.Property(t => t.Previous10Passwords).HasColumnName("Previous10Passwords");
            this.Property(t => t.ForcePasswordChange).HasColumnName("ForcePasswordChange");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.FailedLoginCount).HasColumnName("FailedLoginCount");
            this.Property(t => t.LastLogin).HasColumnName("LastLogin");
            this.Property(t => t.FingerPrintVector).HasColumnName("FingerPrintVector");

            // Relationships
            this.HasRequired(t => t.EmployeesEmployee)
                .WithOptional(t => t.EmployeesUser);

        }
    }
}
