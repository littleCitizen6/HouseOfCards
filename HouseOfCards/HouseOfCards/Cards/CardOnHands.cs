using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    public class CardOnHands
    {
        public Card Card { get; set; }
        public Participant Participant { get; set; }
        public bool IsHinted { get; set; }
        public CardOnHands(Card card, Participant participant)
        {
            Card = card;
            Participant = participant;
            IsHinted = false;
        }
    }
}
