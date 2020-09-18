using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CToSaM1
{
    public class Pixel
    {
        public int X { get; }

        public int Y { get; }

        public Color Color { get; set; }

        public bool WhiteAndBoard { get; set; }

        public Area Area { get; set; }

        public Pixel(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public bool EqualsByCoordinates(int x, int y) => x == this.X && y == this.Y;
    }

    public static class ColorExtension
    {
        const byte whiteRGBBorder = 160;
        static bool RGBEquals(Color color) => color.R == color.G && color.R == color.B && color.B == color.G;
        public static bool IsBlack(this Color color) => RGBEquals(color) && color.R < whiteRGBBorder;
        public static bool IsWhite(this Color color) => RGBEquals(color) && color.R >= whiteRGBBorder;
    }
}