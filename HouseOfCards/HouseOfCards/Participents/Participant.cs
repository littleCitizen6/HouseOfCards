using HouseOfCards.Cards;
using HouseOfCards.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Participents
{
    public abstract class Participant
    {
        public int Id { get; }
        protected List<IOperation> _allowedOperations;
        public Participant(int id)
        {
            _allowedOperations = new List<IOperation>();
            Id = id;
        }
        public Card DrawCard(GameManeger maneger)
        {
            var card = maneger.Info.Deck.DrewCard();
            maneger.Info.CardOnHands.Add(new CardOnHands(card, this));
            return card;
        }
        public abstract void MakeTurn(GameManeger maneger);
        

    }
}
