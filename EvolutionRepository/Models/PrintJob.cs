using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class PrintJob
    {
        public int PrintJobID { get; set; }
        public int OrganisationID { get; set; }
        public string PrintJob1 { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.DateTime> InstructionIssuedAt { get; set; }
        public Nullable<int> InstructionID { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
