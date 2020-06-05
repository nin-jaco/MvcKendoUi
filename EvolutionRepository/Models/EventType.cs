using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EventType
    {
        public EventType()
        {
            this.EventTypesEvents = new List<Event>();
        }

        public int EventTypeID { get; set; }
        public string Description { get; set; }
        public int EventType1 { get; set; }
        public bool IsReportable { get; set; }
        public bool HasIntegerData { get; set; }
        public int DialbackCount { get; set; }
        public bool CreateServiceCall { get; set; }
        public bool CreateNotification { get; set; }
        public Nullable<int> NotificationTypeID { get; set; }
        public virtual ICollection<Event> EventTypesEvents { get; set; }
        public virtual NotificationType NotificationTypesNotificationType { get; set; }
    }
}
