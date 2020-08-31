using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Cards
{
    public class Deck
    {
        public bool IsEmpty => Cards.Count == 0;
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
            LoadDeck();
        }

        private void LoadDeck()
        {
            for (int i = 0; i < 5; i++) //ToDo: change the card load
            {
                Cards.Add(new Card(1, (Color)i));
                Cards.Add(new Card(1, (Color)i));
                Cards.Add(new Card(1, (Color)i));
                Cards.Add(new Card(2, (Color)i));
                Cards.Add(new Card(2, (Color)i));
                Cards.Add(new Card(3, (Color)i));
                Cards.Add(new Card(3, (Color)i));
                Cards.Add(new Card(4, (Color)i));
                Cards.Add(new Card(4, (Color)i));
                Cards.Add(new Card(5, (Color)i));
            };
        }
        public Card DrewCard()
        {
            var last = Cards.Last();
            Cards.Remove(last);
            return last;
        }
    }
}
