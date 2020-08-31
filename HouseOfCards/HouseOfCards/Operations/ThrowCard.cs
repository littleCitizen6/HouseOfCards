using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Operations
{
    public class ThrowCard : IOperation
    {
        public void Operate(Participant participant, GameManeger maneger)
        {
            maneger.Info.CardOnHands.Remove(maneger.Info.CardOnHands.FirstOrDefault(card => card.Participant.Id == participant.Id));
            if(maneger.Info.Hints < 5)
            {
                maneger.Info.Hints++;
            }
        }
    }
}
