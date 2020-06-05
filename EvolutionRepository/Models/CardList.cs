using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CardList
    {
        public CardList()
        {
            this.CardListCardsCards = new List<Card>();
        }

        public int CardListID { get; set; }
        public int SiteID { get; set; }
        public bool IsPending { get; set; }
        public Nullable<System.DateTime> SDLUpdatedTime { get; set; }
        public int InstructionID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Instruction InstructionsInstruction { get; set; }
        public virtual Site SitesSite { get; set; }
        public virtual ICollection<Card> CardListCardsCards { get; set; }
    }
}
