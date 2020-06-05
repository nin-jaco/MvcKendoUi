using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Group
    {
        public Group()
        {
            this.GroupResourceActionsResourceActions = new List<ResourceAction>();
            this.UserGroupsUsers = new List<User>();
        }

        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> isAdmin { get; set; }
        public int JurisdictionID { get; set; }
        public virtual Jurisdiction JurisdictionsJurisdiction { get; set; }
        public virtual ICollection<ResourceAction> GroupResourceActionsResourceActions { get; set; }
        public virtual ICollection<User> UserGroupsUsers { get; set; }
    }
}
