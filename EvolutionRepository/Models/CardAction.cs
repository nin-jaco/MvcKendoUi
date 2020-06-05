using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CardAction
    {
        public CardAction()
        {
            this.CardActionsCardData = new List<CardData>();
        }

        public int CardActionID { get; set; }
        public string CardActionName { get; set; }
        public virtual ICollection<CardData> CardActionsCardData { get; set; }
    }
}
