using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Card
    {
        public Card()
        {
            this.CardsCardData = new List<CardData>();
            this.CardListCardsCardLists = new List<CardList>();
        }

        public int CardID { get; set; }
        public int CardTypeID { get; set; }
        public int EmployeeID { get; set; }
        public int SiteID { get; set; }
        public int OperatorID { get; set; }
        public int JurisdictionID { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual ICollection<CardData> CardsCardData { get; set; }
        public virtual CardType CardTypesCardType { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
        public virtual ICollection<CardList> CardListCardsCardLists { get; set; }
    }
}
