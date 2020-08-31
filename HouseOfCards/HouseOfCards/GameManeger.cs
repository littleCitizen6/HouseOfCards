using HouseOfCards.GameInfo;
using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards
{
    public class GameManeger
    {
        const int DISQUALIFICATIONS_ALLOWED_COUNT = 4;
        const int START_PARTICIPENT_CARDS_COUNT = 5;
        const int START_PARTICIPENT_INDEX = 0;
        public IGameStateInfo Info { get; set; }
        public GameManeger(IEnumerable<Participant> participants)
        {
            Info = new BasicGameStateInfo(participants);
        }

        public void DivideCards()
        {
            for (int i = 0; i < START_PARTICIPENT_CARDS_COUNT; i++)
            {
                Info.Participants.ToList().ForEach(participent => participent.DrawCard(this));
            }
        }

        public void Run()
        {
            int participentIndex = START_PARTICIPENT_INDEX;
            int numOfParticipents = Info.Participants.Count();
            do
            {
                Info.Participants.ElementAt(participentIndex % numOfParticipents).MakeTurn(this);
                participentIndex++;
            }
            while (!Info.Deck.IsEmpty && (Info.Disqualifications <= DISQUALIFICATIONS_ALLOWED_COUNT) && !Info.IsCompleted);
        }
    }
}
