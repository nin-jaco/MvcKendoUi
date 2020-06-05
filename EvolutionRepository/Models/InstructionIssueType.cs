using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class InstructionIssueType
    {
        public InstructionIssueType()
        {
            this.InstructionIssueTypesInstructions = new List<Instruction>();
        }

        public int IssueTypeID { get; set; }
        public string IssueTypeName { get; set; }
        public virtual ICollection<Instruction> InstructionIssueTypesInstructions { get; set; }
    }
}
