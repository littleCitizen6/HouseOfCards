using HouseOfCards.Cards;
using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.GameInfo
{
    public class BasicGameStateInfo : IGameStateInfo
    {
        public int Hints { get; set; }
        public int Disqualifications { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
        public List<CardOnHands> CardOnHands { get; set; }
        public Dictionary<Color, List<Card>> ExposedCard { get; set; }
        public Deck Deck { get; set; }

        public BasicGameStateInfo(IEnumerable<Participant> participents)
        {
            Participants = participents;
            CardOnHands = new List<CardOnHands>();
            ExposedCard = new Dictionary<Color, List<Card>>();
            Disqualifications = 0;
            Hints = 5;
            Deck = new Deck();
        }
    }
}
