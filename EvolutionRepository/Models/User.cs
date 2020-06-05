using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class User
    {
        public User()
        {
            this.UserGroupsGroups = new List<Group>();
        }

        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool AccessRightsGranted { get; set; }
        public Nullable<short> PasswordLife { get; set; }
        public Nullable<System.DateTime> DateOfLastPasswordChange { get; set; }
        public Nullable<bool> AutomaticPassword { get; set; }
        public byte[] Previous10Passwords { get; set; }
        public bool ForcePasswordChange { get; set; }
        public byte[] TimeStamp { get; set; }
        public Nullable<byte> FailedLoginCount { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public byte[] FingerPrintVector { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
        public virtual ICollection<Group> UserGroupsGroups { get; set; }
    }
}
