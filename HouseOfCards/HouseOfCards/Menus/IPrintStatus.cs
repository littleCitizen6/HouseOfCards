using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Menus
{
    interface IPrintStatus
    {
        public void PrintGameStatus(Participant participantView);
    }
}
