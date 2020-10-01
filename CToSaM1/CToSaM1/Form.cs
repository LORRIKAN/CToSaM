using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CToSaM1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public event Action<string> OnPicturePathChosen;

        public event Action<double, double> ProceedCalculatingAsync;

        public event Action AbortCalculating;

        public event Func<int> GetProcessedPixelsNum;

        int totalPixelsNum;

        public void OnCalculationCompleted(RunWorkerCompletedEventArgs e, Image editedPicture, string areasNum,
            string avgDiameter, string areasNumPerVolume, string volumeRatio, string algorithmWorkTime)
        {
            progressReporter.Stop();

            if (e.Cancelled)
            {
                progressBar.Value = 0;
                progressLbl.Hide();
            }
            else if (e.Error != null)
            {
                progressBar.Value = 0;
                progressLbl.Hide();

                MessageBox.Show(e.Error.Message);
            }
            else
            {
                pictureBox1.Image = editedPicture;
                dataGridView.Rows.Add(areasNum, avgDiameter, areasNumPerVolume, volumeRatio, algorithmWorkTime);
            }

            abortButt.Enabled = false;

            ToggleControlsEnabled(true);
        }

        private void ReportProgress(int pixelsProcessed)
        {
            double doublePercent = pixelsProcessed / (double)totalPixelsNum;
            int intPercent = (int)(doublePercent * 100.0);
            try
            {
                progressBar.Value = intPercent;
            }
            catch { }

            progressLbl.Text = string.Format("Обработано пикселей: {0} из {1} ({2:P})", pixelsProcessed, totalPixelsNum, doublePercent);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                countButt.Text = "Загрузка изображения...";
                countButt.Enabled = false;
                menuStrip.Enabled = false;
                progressLbl.Text = "";
                OnPicturePathChosen.BeginInvoke(openFileDialog.FileName, callback => 
                {
                    pictureChosen = true;

                    CheckAndEnableCountButt();

                    countButt.Text = "Подсчитать частицы";

                    menuStrip.Enabled = true;
                }, null);

                var picture = new Bitmap(openFileDialog.FileName);
                pictureBox.Image = picture;
                pictureBox1.Image = null;

                totalPixelsNum = picture.Width * picture.Height;

                progressBar.Value = 0;
            }
        }

        private void ToggleControlsEnabled(bool enabled)
        {
            fileToolStripMenuItem.Enabled = enabled;
            openToolStripMenuItem.Enabled = enabled;
            countButt.Enabled = enabled;

            pictureHeightTextBox.Enabled = enabled;
            pictureWidthTextBox.Enabled = enabled;
        }

        private void CountButtClick(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressLbl.Show();

            ToggleControlsEnabled(false);

            abortButt.Enabled = true;

            dataGridView.Rows.Clear();

            ProceedCalculatingAsync(pictureHeightInMms, pictureWidthInMms);

            progressReporter.Start();
        }

        private void AbortButtClick(object sender, EventArgs e)
        {
            AbortCalculating();
        }

        private void ProgressReporter_Tick(object sender, EventArgs e)
        {
            ReportProgress(GetProcessedPixelsNum());
        }


        #region Обработка правильности ввода

        private bool pictureChosen;
        private double pictureHeightInMms;
        private double pictureWidthInMms;
        private void CheckAndEnableCountButt()
        {
            bool heightAndWidthRetrieved =
                double.TryParse(pictureHeightTextBox.Text, out pictureHeightInMms) && pictureHeightInMms > 0
                && double.TryParse(pictureWidthTextBox.Text, out pictureWidthInMms) && pictureWidthInMms > 0;

            countButt.Enabled = heightAndWidthRetrieved && pictureChosen;
        }

        private void PictureHeightTextBoxTextChanged(object sender, EventArgs e)
        {
            CheckAndEnableCountButt();
        }

        private void PictureWidthTextBoxTextChanged(object sender, EventArgs e)
        {
            PictureHeightTextBoxTextChanged(sender, e);
        }

        #endregion
    }
}