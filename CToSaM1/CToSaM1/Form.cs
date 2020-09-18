using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
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

        public event Action<string> PicturePathChosen;

        public event Action ProceedCalculatingAsync;

        public event Action AbortCalculating;

        public void ShowPictureAndPrepareControls(Image picture)
        {
            countButt.Enabled = true;

            pictureBox.Image = picture;
            pictureBox1.Image = null;

            progressBar.Maximum = picture.Width * picture.Height;
            progressBar.Value = 0;
        }

        public void IncrementProgress()
        {
            progressBar.Value++;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicturePathChosen.Invoke(openFileDialog.FileName);
            }
        }

        private void ToggleButtsEnabled(bool enabled)
        {
            fileToolStripMenuItem.Enabled = enabled;
            openToolStripMenuItem.Enabled = enabled;
            countButt.Enabled = enabled;
        }

        public void CalculationCompleted(RunWorkerCompletedEventArgs e, Image editedPicture)
        {
            if (e.Cancelled)
            {
                progressBar.Value = 0;
            }
            else if (e.Error != null)
            {
                progressBar.Value = 0;

                MessageBox.Show(e.Error.Message);
            }
            else
            {
                pictureBox1.Image = editedPicture;
            }

            abortButt.Enabled = false;

            ToggleButtsEnabled(true);
        }

        private void CountButt_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            ToggleButtsEnabled(false);

            abortButt.Enabled = true;

            ProceedCalculatingAsync();
        }

        private void AbortButt_Click(object sender, EventArgs e)
        {
            AbortCalculating.Invoke();
        }
    }
}
