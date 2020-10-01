using System.Drawing;

namespace CToSaM1
{
    public class Pixel
    {
        public int Height { get; }

        public int Width { get; }

        public Color Color { get; set; }

        public bool Processed { get; set; }

        public bool WhiteAndBoard { get; set; }

        public Area Area { get; set; }

        public bool EqualsByCoordinates(int x, int y) => x == this.Width && y == this.Height;

        public Pixel(int height, int width, Color color)
        {
            Height = height;
            Width = width;
            Color = color;
        }
    }
}