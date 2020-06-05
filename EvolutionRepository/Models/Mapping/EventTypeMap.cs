using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EventTypeMap : EntityTypeConfiguration<EventType>
    {
        public EventTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EventTypeID);

            // Properties
            this.Property(t => t.EventTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EventTypes");
            this.Property(t => t.EventTypeID).HasColumnName("EventTypeID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.EventType1).HasColumnName("EventType");
            this.Property(t => t.IsReportable).HasColumnName("IsReportable");
            this.Property(t => t.HasIntegerData).HasColumnName("HasIntegerData");
            this.Property(t => t.DialbackCount).HasColumnName("DialbackCount");
            this.Property(t => t.CreateServiceCall).HasColumnName("CreateServiceCall");
            this.Property(t => t.CreateNotification).HasColumnName("CreateNotification");
            this.Property(t => t.NotificationTypeID).HasColumnName("NotificationTypeID");

            // Relationships
            this.HasOptional(t => t.NotificationTypesNotificationType)
                .WithMany(t => t.NotificationTypesEventTypes)
                .HasForeignKey(d => d.NotificationTypeID);

        }
    }
}
