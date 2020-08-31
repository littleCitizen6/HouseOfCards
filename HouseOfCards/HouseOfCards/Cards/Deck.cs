using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    public class Deck
    {
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
    }
}
