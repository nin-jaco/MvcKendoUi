using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CardType
    {
        public CardType()
        {
            this.CardTypesCards = new List<Card>();
            this.CardTypesEmployeeTypeCardTypes = new List<EmployeeTypeCardType>();
        }

        public int CardTypeID { get; set; }
        public string CardTypeName { get; set; }
        public virtual ICollection<Card> CardTypesCards { get; set; }
        public virtual ICollection<EmployeeTypeCardType> CardTypesEmployeeTypeCardTypes { get; set; }
    }
}
