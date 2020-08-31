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
            do
            {

            }while(!Info.Deck.IsEmpty && Info.Disqualifications <= DISQUALIFICATIONS_ALLOWED_COUNT && !Info.IsCompleted )
        }


    }
}
