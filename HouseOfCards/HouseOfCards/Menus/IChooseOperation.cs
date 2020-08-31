using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Operations
{
    public interface IChooseOperation
    {
        public IOperation ChooseOperation(List<IOperation> operations);
    }
}
