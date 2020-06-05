using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class InstructionType
    {
        public InstructionType()
        {
            this.InstructionTypesInstructions = new List<Instruction>();
        }

        public int InstructionTypeID { get; set; }
        public string InstructionName { get; set; }
        public string SubInstructionType { get; set; }
        public virtual ICollection<Instruction> InstructionTypesInstructions { get; set; }
    }
}
