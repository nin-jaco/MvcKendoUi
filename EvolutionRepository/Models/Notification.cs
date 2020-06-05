using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Notification
    {
        public int NotificationID { get; set; }
        public int CreatedByUserID { get; set; }
        public Nullable<int> TargetOrganisationID { get; set; }
        public Nullable<int> TargetEmployeeID { get; set; }
        public int NotificationTypeID { get; set; }
        public Nullable<int> AcknowledgedByUserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateAcknowledged { get; set; }
        public Nullable<System.DateTime> DateOfSMS { get; set; }
        public Nullable<System.DateTime> DateOfEMail { get; set; }
        public string EntityName { get; set; }
        public Nullable<int> DBPrimaryKey { get; set; }
        public string NotificationText { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
        public virtual NotificationType NotificationTypesNotificationType { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
