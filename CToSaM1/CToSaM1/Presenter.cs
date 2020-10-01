using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CToSaM1
{
    public partial class Presenter
    {
        private readonly Form form;

        private readonly BackgroundWorker backgroundWorker;

        private readonly List<Area> coloredAreas = new List<Area>();

        private Bitmap picture;

        private readonly Stopwatch stopwatch = new Stopwatch();

        private Pixel[,] pixels;

        private double pictureHeightInMms;

        private double pictureWidthInMms;

        private int pixelsProcessed = 0;

        public Presenter(Form form)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += StartAlgorithm;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            this.form = form;
            this.form.OnPicturePathChosen += LoadPicture;
            this.form.ProceedCalculatingAsync += StartCalculating;
            this.form.AbortCalculating += AbortCalculating;
            this.form.GetProcessedPixelsNum += () => pixelsProcessed;
        }

        private async void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                Task<Bitmap> drawPictureTask = Task.Run(DrawPictureFromPixelsArray);

                Values values = CalculateValues();

                Bitmap finalPicture = await drawPictureTask;

                Task resetPresenterTask = Task.Run(ResetPresenter);

                int areasNum = values.AreasNum;
                double avgDiameter = values.AvgDiameter;
                double areasNumPerVolume = values.AreasNumPerVolume;
                double volumeRatio = values.VolumeRatio;
                double algorithmWorkTimeSec = values.AlgorithmWorkTimeSec;

                await resetPresenterTask;

                form.OnCalculationCompleted(e, finalPicture, areasNum.ToString(), string.Format("{0:F} мкм",
                avgDiameter), string.Format("{0:F} мкм⁻³", areasNumPerVolume), string.Format("{0:P}",
                volumeRatio), string.Format("{0:F} с", algorithmWorkTimeSec));
            }
            else
                form.OnCalculationCompleted(e, null, null, null, null, null, null);
        }

        private void AbortCalculating() => backgroundWorker.CancelAsync();

        private void StartCalculating(double pictureHeightInMms, double pictureWidthInMms)
        {
            this.pictureHeightInMms = pictureHeightInMms;
            this.pictureWidthInMms = pictureWidthInMms;
            backgroundWorker.RunWorkerAsync();
        }

        private void InitializePixelsArray()
        {
            this.pixels = new Pixel[picture.Height, picture.Width];

            for (int i = 0; i < picture.Height; i++)
                for (int j = 0; j < picture.Width; j++)
                    pixels[i, j] = new Pixel(i, j, picture.GetPixel(j, i));
        }

        private void LoadPicture(string picturePath)
        {
            this.picture = new Bitmap(picturePath);

            InitializePixelsArray();
        }

        public void Run() => Application.Run(form);
    }
}