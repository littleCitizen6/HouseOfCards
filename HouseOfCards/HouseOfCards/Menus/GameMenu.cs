using HouseOfCards.Displays;
using HouseOfCards.Operations;
using HouseOfCards.Participents;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Menus
{
    public class GameMenu : IChooseOperation, IPrintStatus
    {
        private IDisplay _display;

        public GameMenu(IDisplay display)
        {
            _display = display;
        }
        public IOperation ChooseOperation(List<IOperation> operations)
        {
            int operetionsLength = operations.Count;
            for (int i = 1; i <= operetionsLength; i++)
            {
                _display.Print($"{i} - {operations[i]}");
            }
            _display.Print("Choose operation to play:");
            int index;
            string stringInput = _display.GetInput();
            while (!Int32.TryParse(stringInput, out index) || (index > operetionsLength || index < 1))
            {
                _display.Print("Wrong Input, Choose operation to play");
                stringInput = _display.GetInput();
            }
            return operations[index];
        }

        public void PrintGameStatus(Participant participantView)
        {
            throw new NotImplementedException();
        }

        // Remove all menus, create only operations and bots
    }
}
