using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CToSaM1
{
    public class Presenter
    {
        private Form Form { get; set; }

        private readonly BackgroundWorker backgroundWorker;

        private readonly List<Area> coloredAreas = new List<Area>();

        private Bitmap picture;

        public Pixel[,] pixels;

        public Presenter(Form form)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            Form = form;
            Form.PicturePathChosen += LoadPicture;
            Form.ProceedCalculatingAsync += ProceedCalculating;
            Form.AbortCalculating += AbortCalculating;
        }

        private void AbortCalculating()
        {
            backgroundWorker.CancelAsync();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var editedPicture = new Bitmap(picture.Width, picture.Height);

            var a = coloredAreas.Count;

            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                    editedPicture.SetPixel(i, j, pixels[i, j].Color);

            InitializePixelsArray();

            Form.CalculationCompleted(e, editedPicture);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) => 
            Form.IncrementProgress();

        private void AreaWork(ref Area areaOfUpperPixel, LinkedList<Pixel> whitePixels)
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
                    int x = pixel.X;
                    int y = pixel.Y;

                    pixels[x, y].Area = areaOfUpperPixel;
                    pixels[x, y].Color = areaOfUpperPixel.Color;

                    if (pixel.WhiteAndBoard)
                        areaOfUpperPixel.OutOfPictureRange = true;

                    areaOfUpperPixel.Pixels.AddLast(pixel);

                    backgroundWorker.ReportProgress(0);
                }

                areaOfUpperPixel = null;

                whitePixels.Clear();
            }
        }

        private void ProcessPixel(Pixel pixel, LinkedList<Pixel> whitePixels, ref Area areaOfUpperPixel)
        {
            if (pixel.X == 0 || pixel.Y == 0 || pixel.X == pixels.GetUpperBound(0) || pixel.Y == pixels.GetUpperBound(1))
                pixel.WhiteAndBoard = true;

            whitePixels.AddLast(pixel);

            int xOfUpperPixel = pixel.X - 1;

            if (xOfUpperPixel >= 0 && areaOfUpperPixel == null)
            {
                int yOfUpperPixel = pixel.Y;

                Pixel upperPixel = pixels[xOfUpperPixel, yOfUpperPixel];

                areaOfUpperPixel = upperPixel.Area;
            }
        }

        public void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var whitePixels = new LinkedList<Pixel>();

            Area areaOfUpperPixel = null;

            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    Pixel pixel = pixels[i, j];

                    Color pixelColor = pixel.Color;

                    if (pixelColor.IsBlack())
                    {
                        AreaWork(ref areaOfUpperPixel, whitePixels);

                        backgroundWorker.ReportProgress(0);
                    }
                    else if (j == height - 1)
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

        private void ProceedCalculating() => backgroundWorker.RunWorkerAsync();

        private void InitializePixelsArray()
        {
            this.pixels = new Pixel[picture.Width, picture.Height];

            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                    pixels[i, j] = new Pixel(i, j, picture.GetPixel(i, j));
        }

        private void LoadPicture(string picturePath)
        {
            this.picture = new Bitmap(picturePath);

            InitializePixelsArray();

            Form.ShowPictureAndPrepareControls(picture);
        }

        public void Run() => Application.Run(Form);
    }
}