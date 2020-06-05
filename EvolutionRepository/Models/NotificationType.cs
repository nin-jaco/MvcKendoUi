using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            this.NotificationTypesEventTypes = new List<EventType>();
            this.NotificationTypesNotifications = new List<Notification>();
        }

        public int NotificationTypeID { get; set; }
        public string NotificationTypeName { get; set; }
        public Nullable<bool> SendSMS { get; set; }
        public Nullable<bool> SendEMail { get; set; }
        public Nullable<bool> SendPrintJob { get; set; }
        public Nullable<bool> SendInstruction { get; set; }
        public Nullable<bool> RequiredAcknowledgement { get; set; }
        public Nullable<bool> DisableLogin { get; set; }
        public virtual ICollection<EventType> NotificationTypesEventTypes { get; set; }
        public virtual ICollection<Notification> NotificationTypesNotifications { get; set; }
    }
}
