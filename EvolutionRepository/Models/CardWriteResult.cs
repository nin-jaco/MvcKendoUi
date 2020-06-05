using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CardWriteResult
    {
        public CardWriteResult()
        {
            this.CardWriteResultsCardData = new List<CardData>();
        }

        public int CardWriteResultID { get; set; }
        public string CardWriteResultName { get; set; }
        public bool ForceCardDelete { get; set; }
        public virtual ICollection<CardData> CardWriteResultsCardData { get; set; }
    }
}
