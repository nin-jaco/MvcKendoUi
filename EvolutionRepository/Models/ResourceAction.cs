using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ResourceAction
    {
        public ResourceAction()
        {
            this.GroupResourceActionsGroups = new List<Group>();
        }

        public int ResourceID { get; set; }
        public int ActionID { get; set; }
        public Nullable<bool> IsAuditable { get; set; }
        public virtual Action ActionsAction { get; set; }
        public virtual Resource ResourcesResource { get; set; }
        public virtual ICollection<Group> GroupResourceActionsGroups { get; set; }
    }
}
