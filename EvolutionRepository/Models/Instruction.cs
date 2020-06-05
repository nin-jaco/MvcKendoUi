using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Instruction
    {
        public Instruction()
        {
            this.InstructionsCardData = new List<CardData>();
            this.InstructionsCardLists = new List<CardList>();
        }

        public int InstructionID { get; set; }
        public int IssueTypeID { get; set; }
        public Nullable<int> InstructionTypeID { get; set; }
        public Nullable<int> ByOrganisationID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public int SiteID { get; set; }
        public Nullable<long> MachineID { get; set; }
        public int InstructionStatusID { get; set; }
        public string StatusText { get; set; }
        public Nullable<System.DateTime> IssuedTime { get; set; }
        public Nullable<System.DateTime> ExecutionTime { get; set; }
        public string ProgressText { get; set; }
        public Nullable<int> RetriedInstructionID { get; set; }
        public Nullable<int> MachineCertifiedModelID { get; set; }
        public Nullable<int> SiteServerCertifiedModelID { get; set; }
        public Nullable<long> GameServerID { get; set; }
        public Nullable<long> SiteServerID { get; set; }
        public string CustomParameters { get; set; }
        public virtual ICollection<CardData> InstructionsCardData { get; set; }
        public virtual ICollection<CardList> InstructionsCardLists { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
        public virtual InstructionIssueType InstructionIssueTypesInstructionIssueType { get; set; }
        public virtual InstructionStatu InstructionStatusInstructionStatu { get; set; }
        public virtual InstructionType InstructionTypesInstructionType { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
        public virtual Organisation Organisations1Organisation { get; set; }
    }
}
