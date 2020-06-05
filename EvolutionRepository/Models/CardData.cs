using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CardData
    {
        public int CardDataID { get; set; }
        public int CardID { get; set; }
        public int CardActionID { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string PINCode { get; set; }
        public int PINUpdateID { get; set; }
        public Nullable<int> InstructionID { get; set; }
        public bool AvailableForIssue { get; set; }
        public bool AvailableForUpdate { get; set; }
        public Nullable<int> CardWriteResultID { get; set; }
        public string Comments { get; set; }
        public int LastUpdatedByEmployeeID { get; set; }
        public virtual CardAction CardActionsCardAction { get; set; }
        public virtual Card CardsCard { get; set; }
        public virtual CardWriteResult CardWriteResultsCardWriteResult { get; set; }
        public virtual Employee Employees1Employee { get; set; }
        public virtual Instruction InstructionsInstruction { get; set; }
        public virtual PINUpdate PINUpdatesPINUpdate { get; set; }
    }
}
