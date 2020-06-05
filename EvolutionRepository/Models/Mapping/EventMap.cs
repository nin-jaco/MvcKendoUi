using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventID);

            // Properties
            this.Property(t => t.Notes)
                .HasMaxLength(25);

            this.Property(t => t.Notes1)
                .HasMaxLength(50);

            this.Property(t => t.Notes2)
                .HasMaxLength(50);

            this.Property(t => t.Notes3)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Events");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.ServiceCallID).HasColumnName("ServiceCallID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Notes1).HasColumnName("Notes1");
            this.Property(t => t.Notes2).HasColumnName("Notes2");
            this.Property(t => t.Notes3).HasColumnName("Notes3");
            this.Property(t => t.Alert).HasColumnName("Alert");
            this.Property(t => t.EventTypeID).HasColumnName("EventTypeID");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");

            // Relationships
            this.HasOptional(t => t.EventTypesEventType)
                .WithMany(t => t.EventTypesEvents)
                .HasForeignKey(d => d.EventTypeID);

        }
    }
}
