namespace CToSaM2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outTemp_tb = new System.Windows.Forms.TextBox();
            this.LayerBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.layer3Material = new System.Windows.Forms.ComboBox();
            this.layer3C = new System.Windows.Forms.TextBox();
            this.layer3B = new System.Windows.Forms.TextBox();
            this.layer3A = new System.Windows.Forms.TextBox();
            this.layer3Width = new System.Windows.Forms.TextBox();
            this.inTemp_tb = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.LayerBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.layer2Material = new System.Windows.Forms.ComboBox();
            this.layer2C = new System.Windows.Forms.TextBox();
            this.layer2B = new System.Windows.Forms.TextBox();
            this.layer2A = new System.Windows.Forms.TextBox();
            this.layer2Width = new System.Windows.Forms.TextBox();
            this.inTemp = new System.Windows.Forms.Label();
            this.LayerBox1 = new System.Windows.Forms.GroupBox();
            this.layer1Material = new System.Windows.Forms.ComboBox();
            this.layer1C = new System.Windows.Forms.TextBox();
            this.layer1B = new System.Windows.Forms.TextBox();
            this.layer1A = new System.Windows.Forms.TextBox();
            this.layer1Width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outTemp = new System.Windows.Forms.Label();
            this.Coefs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ovenParamBox = new System.Windows.Forms.GroupBox();
            this.ovenDiametr = new System.Windows.Forms.TextBox();
            this.ovenHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.financeLoss = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gasPrice = new System.Windows.Forms.TextBox();
            this.LayersGB = new System.Windows.Forms.GroupBox();
            this.LayerBox3.SuspendLayout();
            this.LayerBox2.SuspendLayout();
            this.LayerBox1.SuspendLayout();
            this.ovenParamBox.SuspendLayout();
            this.LayersGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // outTemp_tb
            // 
            this.outTemp_tb.Location = new System.Drawing.Point(162, 57);
            this.outTemp_tb.Name = "outTemp_tb";
            this.outTemp_tb.Size = new System.Drawing.Size(124, 26);
            this.outTemp_tb.TabIndex = 22;
            this.outTemp_tb.Text = "300";
            // 
            // LayerBox3
            // 
            this.LayerBox3.Controls.Add(this.label17);
            this.LayerBox3.Controls.Add(this.label15);
            this.LayerBox3.Controls.Add(this.label13);
            this.LayerBox3.Controls.Add(this.layer3Material);
            this.LayerBox3.Controls.Add(this.layer3C);
            this.LayerBox3.Controls.Add(this.layer3B);
            this.LayerBox3.Controls.Add(this.layer3A);
            this.LayerBox3.Controls.Add(this.layer3Width);
            this.LayerBox3.Location = new System.Drawing.Point(12, 348);
            this.LayerBox3.Name = "LayerBox3";
            this.LayerBox3.Size = new System.Drawing.Size(585, 74);
            this.LayerBox3.TabIndex = 4;
            this.LayerBox3.TabStop = false;
            this.LayerBox3.Text = "Слой 3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(278, -3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(206, -3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(130, -3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "A";
            // 
            // layer3Material
            // 
            this.layer3Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layer3Material.FormattingEnabled = true;
            this.layer3Material.Items.AddRange(new object[] {
            "Высокоглиноземистый",
            "Графит",
            "Динас",
            "Доломит",
            "Карборунд на нитридной связке",
            "Карборунд на оксидной связке",
            "Карборунд самосвязанный",
            "Карборунд, сиалоновая связка",
            "Корунд",
            "Красный кирпич",
            "Магнезит",
            "Магнезитохромит",
            "Огнеупорный бетон",
            "Периклазоуглеродистый",
            "Тальк",
            "Углеродистый",
            "Хромомагнезит",
            "Циркон",
            "Шамот"});
            this.layer3Material.Location = new System.Drawing.Point(328, 26);
            this.layer3Material.Name = "layer3Material";
            this.layer3Material.Size = new System.Drawing.Size(238, 28);
            this.layer3Material.TabIndex = 9;
            this.layer3Material.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // layer3C
            // 
            this.layer3C.Location = new System.Drawing.Point(254, 26);
            this.layer3C.Name = "layer3C";
            this.layer3C.ReadOnly = true;
            this.layer3C.Size = new System.Drawing.Size(67, 26);
            this.layer3C.TabIndex = 8;
            // 
            // layer3B
            // 
            this.layer3B.Location = new System.Drawing.Point(178, 26);
            this.layer3B.Name = "layer3B";
            this.layer3B.ReadOnly = true;
            this.layer3B.Size = new System.Drawing.Size(67, 26);
            this.layer3B.TabIndex = 7;
            // 
            // layer3A
            // 
            this.layer3A.Location = new System.Drawing.Point(104, 26);
            this.layer3A.Name = "layer3A";
            this.layer3A.ReadOnly = true;
            this.layer3A.Size = new System.Drawing.Size(67, 26);
            this.layer3A.TabIndex = 6;
            // 
            // layer3Width
            // 
            this.layer3Width.Location = new System.Drawing.Point(22, 26);
            this.layer3Width.Name = "layer3Width";
            this.layer3Width.Size = new System.Drawing.Size(73, 26);
            this.layer3Width.TabIndex = 0;
            this.layer3Width.Text = "0,2";
            // 
            // inTemp_tb
            // 
            this.inTemp_tb.Location = new System.Drawing.Point(12, 57);
            this.inTemp_tb.Name = "inTemp_tb";
            this.inTemp_tb.Size = new System.Drawing.Size(124, 26);
            this.inTemp_tb.TabIndex = 21;
            this.inTemp_tb.Text = "1000";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.Location = new System.Drawing.Point(6, 554);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(537, 78);
            this.CalculateBtn.TabIndex = 23;
            this.CalculateBtn.Text = "Рассчитать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // LayerBox2
            // 
            this.LayerBox2.Controls.Add(this.label16);
            this.LayerBox2.Controls.Add(this.label14);
            this.LayerBox2.Controls.Add(this.label11);
            this.LayerBox2.Controls.Add(this.layer2Material);
            this.LayerBox2.Controls.Add(this.layer2C);
            this.LayerBox2.Controls.Add(this.layer2B);
            this.LayerBox2.Controls.Add(this.layer2A);
            this.LayerBox2.Controls.Add(this.layer2Width);
            this.LayerBox2.Location = new System.Drawing.Point(12, 263);
            this.LayerBox2.Name = "LayerBox2";
            this.LayerBox2.Size = new System.Drawing.Size(585, 78);
            this.LayerBox2.TabIndex = 1;
            this.LayerBox2.TabStop = false;
            this.LayerBox2.Text = "Слой 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(278, -3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(206, -3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(130, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "A";
            // 
            // layer2Material
            // 
            this.layer2Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layer2Material.FormattingEnabled = true;
            this.layer2Material.Items.AddRange(new object[] {
            "Высокоглиноземистый",
            "Графит",
            "Динас",
            "Доломит",
            "Карборунд на нитридной связке",
            "Карборунд на оксидной связке",
            "Карборунд самосвязанный",
            "Карборунд, сиалоновая связка",
            "Корунд",
            "Красный кирпич",
            "Магнезит",
            "Магнезитохромит",
            "Огнеупорный бетон",
            "Периклазоуглеродистый",
            "Тальк",
            "Углеродистый",
            "Хромомагнезит",
            "Циркон",
            "Шамот"});
            this.layer2Material.Location = new System.Drawing.Point(328, 25);
            this.layer2Material.Name = "layer2Material";
            this.layer2Material.Size = new System.Drawing.Size(238, 28);
            this.layer2Material.TabIndex = 7;
            this.layer2Material.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // layer2C
            // 
            this.layer2C.Location = new System.Drawing.Point(254, 26);
            this.layer2C.Name = "layer2C";
            this.layer2C.ReadOnly = true;
            this.layer2C.Size = new System.Drawing.Size(67, 26);
            this.layer2C.TabIndex = 8;
            // 
            // layer2B
            // 
            this.layer2B.Location = new System.Drawing.Point(178, 26);
            this.layer2B.Name = "layer2B";
            this.layer2B.ReadOnly = true;
            this.layer2B.Size = new System.Drawing.Size(67, 26);
            this.layer2B.TabIndex = 7;
            // 
            // layer2A
            // 
            this.layer2A.Location = new System.Drawing.Point(104, 26);
            this.layer2A.Name = "layer2A";
            this.layer2A.ReadOnly = true;
            this.layer2A.Size = new System.Drawing.Size(67, 26);
            this.layer2A.TabIndex = 6;
            // 
            // layer2Width
            // 
            this.layer2Width.Location = new System.Drawing.Point(22, 26);
            this.layer2Width.Name = "layer2Width";
            this.layer2Width.Size = new System.Drawing.Size(73, 26);
            this.layer2Width.TabIndex = 0;
            this.layer2Width.Text = "1,5";
            // 
            // inTemp
            // 
            this.inTemp.AutoSize = true;
            this.inTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inTemp.Location = new System.Drawing.Point(16, 22);
            this.inTemp.Name = "inTemp";
            this.inTemp.Size = new System.Drawing.Size(124, 25);
            this.inTemp.TabIndex = 26;
            this.inTemp.Text = "T (внутр.), К";
            // 
            // LayerBox1
            // 
            this.LayerBox1.Controls.Add(this.layer1Material);
            this.LayerBox1.Controls.Add(this.layer1C);
            this.LayerBox1.Controls.Add(this.layer1B);
            this.LayerBox1.Controls.Add(this.layer1A);
            this.LayerBox1.Controls.Add(this.layer1Width);
            this.LayerBox1.Controls.Add(this.label2);
            this.LayerBox1.Controls.Add(this.label4);
            this.LayerBox1.Controls.Add(this.label3);
            this.LayerBox1.Location = new System.Drawing.Point(12, 174);
            this.LayerBox1.Name = "LayerBox1";
            this.LayerBox1.Size = new System.Drawing.Size(585, 83);
            this.LayerBox1.TabIndex = 0;
            this.LayerBox1.TabStop = false;
            this.LayerBox1.Text = "Слой 1";
            // 
            // layer1Material
            // 
            this.layer1Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layer1Material.FormattingEnabled = true;
            this.layer1Material.Items.AddRange(new object[] {
            "Высокоглиноземистый",
            "Графит",
            "Динас",
            "Доломит",
            "Карборунд на нитридной связке",
            "Карборунд на оксидной связке",
            "Карборунд самосвязанный",
            "Карборунд, сиалоновая связка",
            "Корунд",
            "Красный кирпич",
            "Магнезит",
            "Магнезитохромит",
            "Огнеупорный бетон",
            "Периклазоуглеродистый",
            "Тальк",
            "Углеродистый",
            "Хромомагнезит",
            "Циркон",
            "Шамот"});
            this.layer1Material.Location = new System.Drawing.Point(328, 28);
            this.layer1Material.Name = "layer1Material";
            this.layer1Material.Size = new System.Drawing.Size(238, 28);
            this.layer1Material.TabIndex = 6;
            this.layer1Material.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // layer1C
            // 
            this.layer1C.Location = new System.Drawing.Point(254, 29);
            this.layer1C.Name = "layer1C";
            this.layer1C.ReadOnly = true;
            this.layer1C.Size = new System.Drawing.Size(67, 26);
            this.layer1C.TabIndex = 5;
            // 
            // layer1B
            // 
            this.layer1B.Location = new System.Drawing.Point(178, 29);
            this.layer1B.Name = "layer1B";
            this.layer1B.ReadOnly = true;
            this.layer1B.Size = new System.Drawing.Size(67, 26);
            this.layer1B.TabIndex = 4;
            // 
            // layer1A
            // 
            this.layer1A.Location = new System.Drawing.Point(104, 29);
            this.layer1A.Name = "layer1A";
            this.layer1A.ReadOnly = true;
            this.layer1A.Size = new System.Drawing.Size(67, 26);
            this.layer1A.TabIndex = 1;
            // 
            // layer1Width
            // 
            this.layer1Width.Location = new System.Drawing.Point(22, 29);
            this.layer1Width.Name = "layer1Width";
            this.layer1Width.Size = new System.Drawing.Size(73, 26);
            this.layer1Width.TabIndex = 0;
            this.layer1Width.Text = "0,4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(130, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(278, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Толщина слоя, м";
            // 
            // outTemp
            // 
            this.outTemp.AutoSize = true;
            this.outTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outTemp.Location = new System.Drawing.Point(158, 22);
            this.outTemp.Name = "outTemp";
            this.outTemp.Size = new System.Drawing.Size(118, 25);
            this.outTemp.TabIndex = 27;
            this.outTemp.Text = "Т (внеш.), К";
            // 
            // Coefs
            // 
            this.Coefs.AutoSize = true;
            this.Coefs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coefs.Location = new System.Drawing.Point(6, 105);
            this.Coefs.Name = "Coefs";
            this.Coefs.Size = new System.Drawing.Size(506, 26);
            this.Coefs.TabIndex = 31;
            this.Coefs.Text = "Коэффициенты теплопроводности, Вт/(м*К)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Огнеупор";
            // 
            // ovenParamBox
            // 
            this.ovenParamBox.Controls.Add(this.ovenDiametr);
            this.ovenParamBox.Controls.Add(this.ovenHeight);
            this.ovenParamBox.Controls.Add(this.label6);
            this.ovenParamBox.Controls.Add(this.label5);
            this.ovenParamBox.Location = new System.Drawing.Point(12, 429);
            this.ovenParamBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ovenParamBox.Name = "ovenParamBox";
            this.ovenParamBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ovenParamBox.Size = new System.Drawing.Size(276, 117);
            this.ovenParamBox.TabIndex = 36;
            this.ovenParamBox.TabStop = false;
            this.ovenParamBox.Text = "Параметры печи";
            // 
            // ovenDiametr
            // 
            this.ovenDiametr.Location = new System.Drawing.Point(158, 55);
            this.ovenDiametr.Name = "ovenDiametr";
            this.ovenDiametr.Size = new System.Drawing.Size(109, 26);
            this.ovenDiametr.TabIndex = 8;
            this.ovenDiametr.Text = "2";
            // 
            // ovenHeight
            // 
            this.ovenHeight.Location = new System.Drawing.Point(158, 20);
            this.ovenHeight.Name = "ovenHeight";
            this.ovenHeight.Size = new System.Drawing.Size(109, 26);
            this.ovenHeight.TabIndex = 7;
            this.ovenHeight.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Диаметр печи, м";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Высота печи, м";
            // 
            // financeLoss
            // 
            this.financeLoss.AutoSize = true;
            this.financeLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.financeLoss.Location = new System.Drawing.Point(617, 288);
            this.financeLoss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.financeLoss.Name = "financeLoss";
            this.financeLoss.Size = new System.Drawing.Size(0, 37);
            this.financeLoss.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 474);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Цена газа, руб/100м^3";
            // 
            // gasPrice
            // 
            this.gasPrice.Location = new System.Drawing.Point(495, 469);
            this.gasPrice.Name = "gasPrice";
            this.gasPrice.Size = new System.Drawing.Size(72, 26);
            this.gasPrice.TabIndex = 39;
            this.gasPrice.Text = "4500";
            // 
            // LayersGB
            // 
            this.LayersGB.Controls.Add(this.gasPrice);
            this.LayersGB.Controls.Add(this.label7);
            this.LayersGB.Controls.Add(this.financeLoss);
            this.LayersGB.Controls.Add(this.ovenParamBox);
            this.LayersGB.Controls.Add(this.label9);
            this.LayersGB.Controls.Add(this.Coefs);
            this.LayersGB.Controls.Add(this.outTemp);
            this.LayersGB.Controls.Add(this.label1);
            this.LayersGB.Controls.Add(this.LayerBox1);
            this.LayersGB.Controls.Add(this.inTemp);
            this.LayersGB.Controls.Add(this.LayerBox2);
            this.LayersGB.Controls.Add(this.CalculateBtn);
            this.LayersGB.Controls.Add(this.inTemp_tb);
            this.LayersGB.Controls.Add(this.LayerBox3);
            this.LayersGB.Controls.Add(this.outTemp_tb);
            this.LayersGB.Location = new System.Drawing.Point(12, 12);
            this.LayersGB.Name = "LayersGB";
            this.LayersGB.Size = new System.Drawing.Size(1061, 651);
            this.LayersGB.TabIndex = 10;
            this.LayersGB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 668);
            this.Controls.Add(this.LayersGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Плотность теплового потока";
            this.LayerBox3.ResumeLayout(false);
            this.LayerBox3.PerformLayout();
            this.LayerBox2.ResumeLayout(false);
            this.LayerBox2.PerformLayout();
            this.LayerBox1.ResumeLayout(false);
            this.LayerBox1.PerformLayout();
            this.ovenParamBox.ResumeLayout(false);
            this.ovenParamBox.PerformLayout();
            this.LayersGB.ResumeLayout(false);
            this.LayersGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox outTemp_tb;
        private System.Windows.Forms.GroupBox LayerBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox layer3Material;
        private System.Windows.Forms.TextBox layer3C;
        private System.Windows.Forms.TextBox layer3B;
        private System.Windows.Forms.TextBox layer3A;
        private System.Windows.Forms.TextBox layer3Width;
        private System.Windows.Forms.TextBox inTemp_tb;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.GroupBox LayerBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox layer2Material;
        private System.Windows.Forms.TextBox layer2C;
        private System.Windows.Forms.TextBox layer2B;
        private System.Windows.Forms.TextBox layer2A;
        private System.Windows.Forms.TextBox layer2Width;
        private System.Windows.Forms.Label inTemp;
        private System.Windows.Forms.GroupBox LayerBox1;
        private System.Windows.Forms.ComboBox layer1Material;
        private System.Windows.Forms.TextBox layer1C;
        private System.Windows.Forms.TextBox layer1B;
        private System.Windows.Forms.TextBox layer1A;
        private System.Windows.Forms.TextBox layer1Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outTemp;
        private System.Windows.Forms.Label Coefs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox ovenParamBox;
        private System.Windows.Forms.TextBox ovenDiametr;
        private System.Windows.Forms.TextBox ovenHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label financeLoss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gasPrice;
        private System.Windows.Forms.GroupBox LayersGB;
    }
}

