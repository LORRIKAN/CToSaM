using System.Drawing;

namespace CToSaM1
{
    public static class ColorExtension
    {
        private const byte whiteRGBBorder = 100;

        private static bool RGBEquals(Color color) => color.R == color.G && color.R == color.B && color.B == color.G;
        public static bool IsBlack(this Color color) => RGBEquals(color) && color.R < whiteRGBBorder;
        public static bool IsWhite(this Color color) => RGBEquals(color) && color.R >= whiteRGBBorder;
    }
}