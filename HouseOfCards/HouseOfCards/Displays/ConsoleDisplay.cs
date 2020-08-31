using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Displays
{
    class ConsoleDisplay : IDisplay
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }
    }
}
