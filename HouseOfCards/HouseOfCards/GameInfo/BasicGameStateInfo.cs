using HouseOfCards.Cards;
using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.GameInfo
{
    public class BasicGameStateInfo : IGameStateInfo
    {
        const int START_NUMBER_OF_HITS = 5;
        const int START_NUMBER_OF_DISQUALIFICATIONS = 0;
        public int Hints { get; set; }
        public int Disqualifications { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
        public List<CardOnHands> CardOnHands { get; set; }
        public Dictionary<Color, List<Card>> ExposedCard { get; set; }
        public Deck Deck { get; set; }
        public bool IsCompleted => ExposedCard.Keys.ToList().FirstOrDefault(color => ExposedCard[color].Count < 5) == null; // todo: check if work

        public BasicGameStateInfo(IEnumerable<Participant> participents)
        {
            Participants = participents;
            CardOnHands = new List<CardOnHands>();
            ExposedCard = new Dictionary<Color, List<Card>>();
            Disqualifications = START_NUMBER_OF_DISQUALIFICATIONS;
            Hints = START_NUMBER_OF_HITS;
            Deck = new Deck();
        }
    }
}
