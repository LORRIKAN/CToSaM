namespace CToSaM1
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureWidthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureHeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AreasNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreasNumPerVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlgorithmWorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abortButt = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.countButt = new System.Windows.Forms.Button();
            this.progressReporter = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1121, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Картинки|*.jpg;*.jpeg;*.png";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 36);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.progressLbl);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.pictureWidthTextBox);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.pictureHeightTextBox);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Panel2.Controls.Add(this.abortButt);
            this.splitContainer.Panel2.Controls.Add(this.progressBar);
            this.splitContainer.Panel2.Controls.Add(this.countButt);
            this.splitContainer.Size = new System.Drawing.Size(1121, 643);
            this.splitContainer.SplitterDistance = 393;
            this.splitContainer.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 393);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(357, 389);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // progressLbl
            // 
            this.progressLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(321, 85);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(0, 20);
            this.progressLbl.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "мм";
            // 
            // pictureWidthTextBox
            // 
            this.pictureWidthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureWidthTextBox.Location = new System.Drawing.Point(519, 10);
            this.pictureWidthTextBox.Name = "pictureWidthTextBox";
            this.pictureWidthTextBox.Size = new System.Drawing.Size(56, 26);
            this.pictureWidthTextBox.TabIndex = 9;
            this.pictureWidthTextBox.Text = "1";
            this.pictureWidthTextBox.TextChanged += new System.EventHandler(this.PictureWidthTextBoxTextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ширина картинки:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "мм";
            // 
            // pictureHeightTextBox
            // 
            this.pictureHeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureHeightTextBox.Location = new System.Drawing.Point(265, 10);
            this.pictureHeightTextBox.Name = "pictureHeightTextBox";
            this.pictureHeightTextBox.Size = new System.Drawing.Size(56, 26);
            this.pictureHeightTextBox.TabIndex = 6;
            this.pictureHeightTextBox.Text = "1";
            this.pictureHeightTextBox.TextChanged += new System.EventHandler(this.PictureHeightTextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Высота картинки:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AreasNum,
            this.AvgDiameter,
            this.AreasNumPerVolume,
            this.VolumeRatio,
            this.AlgorithmWorkTime});
            this.dataGridView.Location = new System.Drawing.Point(0, 108);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1117, 134);
            this.dataGridView.TabIndex = 4;
            // 
            // AreasNum
            // 
            this.AreasNum.HeaderText = "Количество частиц";
            this.AreasNum.MinimumWidth = 8;
            this.AreasNum.Name = "AreasNum";
            this.AreasNum.ReadOnly = true;
            this.AreasNum.Width = 150;
            // 
            // AvgDiameter
            // 
            this.AvgDiameter.HeaderText = "Средний диаметр";
            this.AvgDiameter.MinimumWidth = 8;
            this.AvgDiameter.Name = "AvgDiameter";
            this.AvgDiameter.ReadOnly = true;
            this.AvgDiameter.Width = 150;
            // 
            // AreasNumPerVolume
            // 
            this.AreasNumPerVolume.HeaderText = "Число частиц в единице объёма";
            this.AreasNumPerVolume.MinimumWidth = 8;
            this.AreasNumPerVolume.Name = "AreasNumPerVolume";
            this.AreasNumPerVolume.ReadOnly = true;
            this.AreasNumPerVolume.Width = 150;
            // 
            // VolumeRatio
            // 
            this.VolumeRatio.HeaderText = "Объёмная доля";
            this.VolumeRatio.MinimumWidth = 8;
            this.VolumeRatio.Name = "VolumeRatio";
            this.VolumeRatio.ReadOnly = true;
            this.VolumeRatio.Width = 150;
            // 
            // AlgorithmWorkTime
            // 
            this.AlgorithmWorkTime.HeaderText = "Время работы алгоритма";
            this.AlgorithmWorkTime.MinimumWidth = 8;
            this.AlgorithmWorkTime.Name = "AlgorithmWorkTime";
            this.AlgorithmWorkTime.ReadOnly = true;
            this.AlgorithmWorkTime.Width = 150;
            // 
            // abortButt
            // 
            this.abortButt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.abortButt.Enabled = false;
            this.abortButt.Location = new System.Drawing.Point(860, 3);
            this.abortButt.Name = "abortButt";
            this.abortButt.Size = new System.Drawing.Size(142, 40);
            this.abortButt.TabIndex = 3;
            this.abortButt.Text = "Отмена";
            this.abortButt.UseVisualStyleBackColor = true;
            this.abortButt.Click += new System.EventHandler(this.AbortButtClick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(3, 49);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1111, 23);
            this.progressBar.TabIndex = 1;
            // 
            // countButt
            // 
            this.countButt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countButt.Enabled = false;
            this.countButt.Location = new System.Drawing.Point(629, 3);
            this.countButt.Name = "countButt";
            this.countButt.Size = new System.Drawing.Size(225, 40);
            this.countButt.TabIndex = 0;
            this.countButt.Text = "Подсчитать частицы";
            this.countButt.UseVisualStyleBackColor = true;
            this.countButt.Click += new System.EventHandler(this.CountButtClick);
            // 
            // progressReporter
            // 
            this.progressReporter.Tick += new System.EventHandler(this.ProgressReporter_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 679);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form";
            this.Text = "Подсчёт частиц";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button countButt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button abortButt;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreasNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreasNumPerVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlgorithmWorkTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pictureWidthTextBox;
        private System.Windows.Forms.TextBox pictureHeightTextBox;
        private System.Windows.Forms.Timer progressReporter;
        private System.Windows.Forms.Label progressLbl;
    }
}

