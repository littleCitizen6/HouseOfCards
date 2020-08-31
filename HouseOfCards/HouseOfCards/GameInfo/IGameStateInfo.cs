using HouseOfCards.Cards;
using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.GameInfo
{
    public interface IGameStateInfo
    {
        int Hints { get; set; }
        int Disqualifications { get; set; }
        IEnumerable<Participant> Participants{ get; set; }
        List<CardOnHands> CardOnHands { get; set; }
        Dictionary<Color, List<Card>> ExposedCard { get; set; }
    }
}
