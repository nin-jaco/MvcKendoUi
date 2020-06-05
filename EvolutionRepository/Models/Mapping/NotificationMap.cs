using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class NotificationMap : EntityTypeConfiguration<Notification>
    {
        public NotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationID);

            // Properties
            this.Property(t => t.EntityName)
                .HasMaxLength(50);

            this.Property(t => t.NotificationText)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("Notifications");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.CreatedByUserID).HasColumnName("CreatedByUserID");
            this.Property(t => t.TargetOrganisationID).HasColumnName("TargetOrganisationID");
            this.Property(t => t.TargetEmployeeID).HasColumnName("TargetEmployeeID");
            this.Property(t => t.NotificationTypeID).HasColumnName("NotificationTypeID");
            this.Property(t => t.AcknowledgedByUserID).HasColumnName("AcknowledgedByUserID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateAcknowledged).HasColumnName("DateAcknowledged");
            this.Property(t => t.DateOfSMS).HasColumnName("DateOfSMS");
            this.Property(t => t.DateOfEMail).HasColumnName("DateOfEMail");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.DBPrimaryKey).HasColumnName("DBPrimaryKey");
            this.Property(t => t.NotificationText).HasColumnName("NotificationText");

            // Relationships
            this.HasOptional(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesNotifications)
                .HasForeignKey(d => d.TargetEmployeeID);
            this.HasRequired(t => t.NotificationTypesNotificationType)
                .WithMany(t => t.NotificationTypesNotifications)
                .HasForeignKey(d => d.NotificationTypeID);
            this.HasOptional(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsNotifications)
                .HasForeignKey(d => d.TargetOrganisationID);

        }
    }
}
