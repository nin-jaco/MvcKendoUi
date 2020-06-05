using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class NotificationTypeMap : EntityTypeConfiguration<NotificationType>
    {
        public NotificationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationTypeID);

            // Properties
            this.Property(t => t.NotificationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NotificationTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NotificationTypes");
            this.Property(t => t.NotificationTypeID).HasColumnName("NotificationTypeID");
            this.Property(t => t.NotificationTypeName).HasColumnName("NotificationTypeName");
            this.Property(t => t.SendSMS).HasColumnName("SendSMS");
            this.Property(t => t.SendEMail).HasColumnName("SendEMail");
            this.Property(t => t.SendPrintJob).HasColumnName("SendPrintJob");
            this.Property(t => t.SendInstruction).HasColumnName("SendInstruction");
            this.Property(t => t.RequiredAcknowledgement).HasColumnName("RequiredAcknowledgement");
            this.Property(t => t.DisableLogin).HasColumnName("DisableLogin");
        }
    }
}
