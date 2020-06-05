using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Action
    {
        public Action()
        {
            this.ActionsResourceActions = new List<ResourceAction>();
        }

        public int ActionID { get; set; }
        public string ActionName { get; set; }
        public string MenuName { get; set; }
        public bool IsMDI { get; set; }
        public virtual ICollection<ResourceAction> ActionsResourceActions { get; set; }
    }
}
