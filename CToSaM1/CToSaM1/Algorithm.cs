using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CToSaM1
{
    public partial class Presenter
    {
        private void AreaWork(ref Area areaOfUpperPixel, List<Pixel> whitePixels)
        {
            if (whitePixels.Any())
            {
                if (areaOfUpperPixel == null)
                {
                    areaOfUpperPixel = new Area();
                    coloredAreas.Add(areaOfUpperPixel);
                }

                foreach (Pixel pixel in whitePixels)
                {
                    int height = pixel.Height;
                    int width = pixel.Width;

                    pixels[height, width].Area = areaOfUpperPixel;
                    pixels[height, width].Color = areaOfUpperPixel.Color;

                    if (pixel.WhiteAndBoard)
                        areaOfUpperPixel.OutOfPictureRange = true;

                    areaOfUpperPixel.Pixels.Add(pixel);

                    if (!pixel.Processed)
                    {
                        pixel.Processed = true;
                        pixelsProcessed++;
                    }
                }

                areaOfUpperPixel = null;

                whitePixels.Clear();
            }
        }

        private void ProcessPixel(Pixel pixel, List<Pixel> whitePixels, ref Area areaOfUpperPixel)
        {
            if (pixel.Width == 0 || pixel.Height == 0 || pixel.Width == pixels.GetUpperBound(0) || pixel.Height == pixels.GetUpperBound(1))
                pixel.WhiteAndBoard = true;

            whitePixels.Add(pixel);

            int heightOfUpperPixel = pixel.Height - 1;

            if (heightOfUpperPixel >= 0)
            {
                int widthOfUpperPixel = pixel.Width;

                Pixel upperPixel = pixels[heightOfUpperPixel, widthOfUpperPixel];

                if (upperPixel.Area != null)
                {
                    if (areaOfUpperPixel != upperPixel.Area && areaOfUpperPixel != null)
                    {
                        foreach (Pixel pixelToChange in areaOfUpperPixel.Pixels)
                            whitePixels.Add(pixelToChange);

                        coloredAreas.Remove(areaOfUpperPixel);
                    }

                    areaOfUpperPixel = upperPixel.Area;
                }
            }
        }

        private void StartAlgorithm(object sender, DoWorkEventArgs e)
        {
            var whitePixels = new List<Pixel>();

            Area areaOfUpperPixel = null;

            int height = pixels.GetLength(0);
            int width = pixels.GetLength(1);

            stopwatch.Start();
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        ResetPresenter();
                        return;
                    }

                    Pixel pixel = pixels[i, j];

                    Color pixelColor = pixel.Color;

                    if (pixelColor.IsBlack())
                    {
                        AreaWork(ref areaOfUpperPixel, whitePixels);

                        pixelsProcessed++;
                    }
                    else if (j == width - 1)
                    {
                        ProcessPixel(pixel, whitePixels, ref areaOfUpperPixel);

                        AreaWork(ref areaOfUpperPixel, whitePixels);
                    }
                    else
                    {
                        ProcessPixel(pixel, whitePixels, ref areaOfUpperPixel);
                    }
                }
        }

        struct Values
        {
            public Values(int areasNum, double avgDiameter, double areasNumPerVolume, double volumeRatio, double algorithmWorkTimeSec)
            {
                AreasNum = areasNum;
                AvgDiameter = avgDiameter;
                AreasNumPerVolume = areasNumPerVolume;
                VolumeRatio = volumeRatio;
                AlgorithmWorkTimeSec = algorithmWorkTimeSec;
            }

            public int AreasNum { get; set; }
            public double AvgDiameter { get; set; }
            public double AreasNumPerVolume { get; set; }
            public double VolumeRatio { get; set; }
            public double AlgorithmWorkTimeSec { get; set; }
        }

        private Values CalculateValues()
        {
            int areasNum = coloredAreas.Count;

            double coloredPixelsNum = 0;
            double diametersSum = 0;
            const double mkmsInMm = 1000;
            double mkmsInPixel = ((pictureHeightInMms * mkmsInMm) * (pictureWidthInMms * mkmsInMm)) / (picture.Width * picture.Height);
            Parallel.ForEach(coloredAreas, area => { coloredPixelsNum += area.Pixels.Count; diametersSum += area.CalculateDiameter(mkmsInPixel); }); 

            double avgDiameter = diametersSum / areasNum;

            double areasNumPerVolume = areasNum / avgDiameter;

            double volumeRatio = coloredPixelsNum / (picture.Height * picture.Width);

            double algorithmWorkTimeSec = stopwatch.Elapsed.TotalSeconds;

            return new Values(areasNum, avgDiameter, areasNumPerVolume, volumeRatio, algorithmWorkTimeSec);
        }

        private Bitmap DrawPictureFromPixelsArray()
        {
            var drawablePicture = new Bitmap(picture.Width, picture.Height);

            for (int i = 0; i < drawablePicture.Height; i++)
                for (int j = 0; j < drawablePicture.Width; j++)
                    drawablePicture.SetPixel(j, i, pixels[i, j].Color);

            return drawablePicture;
        }

        private void ResetPresenter()
        {
            InitializePixelsArray();

            coloredAreas.Clear();

            stopwatch.Reset();

            pixelsProcessed = 0;
        }
    }
}