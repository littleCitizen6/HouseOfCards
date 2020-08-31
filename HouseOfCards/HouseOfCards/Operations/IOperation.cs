using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Operations
{
    public interface IOperation
    {
        void Operate(Participant participant, GameManeger maneger);
    }
}
