using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class InstructionStatu
    {
        public InstructionStatu()
        {
            this.InstructionStatusInstructions = new List<Instruction>();
        }

        public int InstructionStatusID { get; set; }
        public string InstructionStatusName { get; set; }
        public virtual ICollection<Instruction> InstructionStatusInstructions { get; set; }
    }
}
