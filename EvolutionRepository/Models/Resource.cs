using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Resource
    {
        public Resource()
        {
            this.ResourcesResourceActions = new List<ResourceAction>();
        }

        public int ResourceID { get; set; }
        public string ResourceName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<bool> IsDialogAdd { get; set; }
        public Nullable<bool> IsDialogList { get; set; }
        public Nullable<bool> IsMenuItem { get; set; }
        public Nullable<bool> IsBrowserPage { get; set; }
        public Nullable<int> ResourceLocationID { get; set; }
        public string Description { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public virtual ICollection<ResourceAction> ResourcesResourceActions { get; set; }
    }
}
