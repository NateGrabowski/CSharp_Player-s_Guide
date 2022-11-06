using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_24___Boss_Battles
{
    public class Card
    {
        //public int deck { get; }
        public rank? Rank { get; }
        public color? Color { get; }
        public symbol? Symbol { get; }
        public enum rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }
        public enum color { Red, Green, Blue, Yellow }
        public enum symbol { Dollar, Percent, Up_Point, Ampersand }
        //card static deck prop
        public Card(color color, rank rank)
        {
            Color = color;
            Rank = rank;
        }
        public Card(color color, symbol symbol)
        {
            Color = color;
            Symbol = symbol;
        }

        public Card(object enumcolor, object rank) //TODO: convert these objects to enum props
        {
        }

        public void DisplayCard() //tells you if number or face card
        {
            if (Rank != null) Console.WriteLine($"The {Color} {Rank}"); Console.WriteLine($"The {Color} {Symbol}");
        }

    }
}
