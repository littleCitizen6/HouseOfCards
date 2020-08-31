using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    public class CardOnHands
    {
        public Card Card { get; set; }
        public Participant Participant { get; set; }
        public bool Hinted { get; set; }
    }
}
