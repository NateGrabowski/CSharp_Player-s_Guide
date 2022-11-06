using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_24___Boss_Battles
{
    internal class Color
    {
        //int _r = 0, _g = 0, _b = 0;
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Green { get; } = new Color(0, 128, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color Purple { get; } = new Color(128, 0, 128);

        //public int R
        //{
        //    get => _r;
        //    set { if (value >= 0 && value <= 255) _r = value; throw new ArgumentOutOfRangeException("0-255 are the only RGB values"); }
        //}
        //public int G
        //{
        //    get => _g;
        //    set { if (value >= 0 && value <= 255) _g = value; throw new ArgumentOutOfRangeException("0-255 are the only RGB values"); }
        //}
        //public int B
        //{
        //    get => _b;
        //    set { if (value >= 0 && value <= 255) _b = value; throw new ArgumentOutOfRangeException("0-255 are the only RGB values"); }
        //}

        //public Color()
        //{

        //}
        //public Color(int red, int green, int blue)
        //{
        //    R = red;
        //    G = green;
        //    B = blue;

        //}
        public void DisplayRGB() => Console.WriteLine($"Red: {R}\nGreen: {G}\nBlue: {B}");
    }
}
