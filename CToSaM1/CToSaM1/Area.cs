using System;
using System.Collections.Generic;
using System.Drawing;

namespace CToSaM1
{
    public class Area
    {
        public Color Color { get; }

        public bool OutOfPictureRange { get; set; }

        public LinkedList<Pixel> Pixels { get; } = new LinkedList<Pixel>();

        public int Diameter { get; }

        public void CalculateDiameter()
        {

        }

        public Area()
        {
            do
            {
                int randomArgbColor = colorRandomizer.Next(Color.Navy.ToArgb(), Color.Red.ToArgb());
                Color = Color.FromArgb(randomArgbColor);
            } while (Color.IsBlack() && Color.IsWhite());
        }

        private static readonly Random colorRandomizer = new Random();
    }
}