using HouseOfCards.Participents;
using System;
using System.Collections.Generic;

namespace HouseOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BasicParticipent p1 = new BasicParticipent(1);
            BasicParticipent p2 = new BasicParticipent(2);
            BasicParticipent p3 = new BasicParticipent(3);
            BasicParticipent p4 = new BasicParticipent(4);
            GameManeger maneger = new GameManeger(new List<BasicParticipent>() { p1, p2, p3, p4});
            maneger.Run();
        }
    }
}
