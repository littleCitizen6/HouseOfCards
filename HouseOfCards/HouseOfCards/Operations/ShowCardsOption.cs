using HouseOfCards.Cards;
using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Operations
{
    public class ShowCardsOption : IOperation
    {
        public void Operate(Participant participant, GameManeger maneger)
        {
            var cards = maneger.Info.CardOnHands.Where(x => x.Participant.Id == participant.Id && x.IsHinted);
            if (cards != null)
            {
                List<Card> optional = new List<Card>();
                maneger.Info.ExposedCard.Keys.ToList().ForEach(color => optional.Add(maneger.Info.ExposedCard[color].Last()));
            }
        }
    }
}
