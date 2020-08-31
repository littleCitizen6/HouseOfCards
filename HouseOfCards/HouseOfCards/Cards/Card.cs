using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    public enum Color
    {
        red,
        green,
        blue, 
        yellow,
        white
    } 
    public class Card
    {
        public int Value { get; set; }
        public Color Color { get; set; }
        public Card(int valur, Color color)
        {
            Value = valur;
            Color = color;
        }
    }
}
