using System;
using System.Collections.Generic;
using System.Drawing;

namespace CToSaM1
{
    public class Area
    {
        public Color Color { get; }

        public bool OutOfPictureRange { get; set; }

        public List<Pixel> Pixels { get; } = new List<Pixel>();

        public double CalculateDiameter(double mkmsInPixel)
        {
            double square = Pixels.Count * mkmsInPixel;

            double diameter = 2 * Math.Sqrt(square / Math.PI);

            return diameter;
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