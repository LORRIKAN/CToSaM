using System;
using System.Collections.Generic;
using System.Drawing;

namespace CToSaM1
{
    public class Area
    {
        public Color Color { get; set; }

        static readonly Random colorRandomizer = new Random();

        public int PixelsFound { get; private set; } = 0;

        public bool OutOfPictureRange { get; set; }

        public LinkedList<Pixel> Pixels { get; } = new LinkedList<Pixel>();

        public Area()
        {
            do
            {
                int randomArgbColor = colorRandomizer.Next(Color.Navy.ToArgb(), Color.Red.ToArgb());
                Color = Color.FromArgb(randomArgbColor);
            } while (Color.IsBlack() && Color.IsWhite());
        }
    }
}