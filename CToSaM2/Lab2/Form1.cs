using System;
using System.Linq;
using System.Windows.Forms;

namespace CToSaM2
{
    public partial class Form1 : Form
    {
        readonly PolyCoef[] CoefArr;

        public Form1()
        {
            InitializeComponent();
            CoefArr = new PolyCoef[19];

            CoefArr[0] = new PolyCoef(2.681, -1.278, 0.454);
            CoefArr[1] = new PolyCoef(98.939, -85.038, 30.492);
            CoefArr[2] = new PolyCoef(0.930, 0.690, 0.000);
            CoefArr[3] = new PolyCoef(3.180, 0.886, -1.429);
            CoefArr[4] = new PolyCoef(30.975, -21.460, 7.701);
            CoefArr[5] = new PolyCoef(28.200, -48.857, 25.000);
            CoefArr[6] = new PolyCoef(48.200, -68.857, 32.143);
            CoefArr[7] = new PolyCoef(34.350, -53.179, 25.893);
            CoefArr[8] = new PolyCoef(3.228, -1.216, 0.439);
            CoefArr[9] = new PolyCoef(0.760, 0.440, 0.000);
            CoefArr[10] = new PolyCoef(4.700, -1.700, 0.000);
            CoefArr[11] = new PolyCoef(4.060, -1.700, 0.000);
            CoefArr[12] = new PolyCoef(0.440, 0.465, 0.000);
            CoefArr[13] = new PolyCoef(29.000, -27.500, 12.500);
            CoefArr[14] = new PolyCoef(1.050, 0.310, 0.000);
            CoefArr[15] = new PolyCoef(2.352, 5.916, -0.338);
            CoefArr[16] = new PolyCoef(2.800, -0.870, 0.000);
            CoefArr[17] = new PolyCoef(4.543, -4.399, 1.935);
            CoefArr[18] = new PolyCoef(0.840, 0.580, 0.000);

            layer1Material.SelectedIndex = 0;
            layer2Material.SelectedIndex = 0;
            layer3Material.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            layer1A.Text = CoefArr[layer1Material.SelectedIndex].A.ToString();
            layer1B.Text = CoefArr[layer1Material.SelectedIndex].B.ToString();
            layer1C.Text = CoefArr[layer1Material.SelectedIndex].C.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            layer2A.Text = CoefArr[layer2Material.SelectedIndex].A.ToString();
            layer2B.Text = CoefArr[layer2Material.SelectedIndex].B.ToString();
            layer2C.Text = CoefArr[layer2Material.SelectedIndex].C.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            layer3A.Text = CoefArr[layer3Material.SelectedIndex].A.ToString();
            layer3B.Text = CoefArr[layer3Material.SelectedIndex].B.ToString();
            layer3C.Text = CoefArr[layer3Material.SelectedIndex].C.ToString();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            const int layersNum = 3;

            Layer[] layers = new Layer[layersNum];

            layers[0] = new Layer(Convert.ToDouble(layer1Width.Text), Convert.ToDouble(layer1A.Text), Convert.ToDouble(layer1B.Text), Convert.ToDouble(layer1C.Text), 0, 0);
            layers[1] = new Layer(Convert.ToDouble(layer2Width.Text), Convert.ToDouble(layer2A.Text), Convert.ToDouble(layer2B.Text), Convert.ToDouble(layer2C.Text), 0, 0);
            layers[2] = new Layer(Convert.ToDouble(layer3Width.Text), Convert.ToDouble(layer3A.Text), Convert.ToDouble(layer3B.Text), Convert.ToDouble(layer3C.Text), 0, 0);

            if (ovenHeight.Text == "" || ovenDiametr.Text == "" || gasPrice.Text == "")
            {
                MessageBox.Show("Введите все параметры", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double maxTemp = Convert.ToDouble(inTemp_tb.Text);
            double minTemp = Convert.ToDouble(outTemp_tb.Text);

            double totalLength = layers.Select(l => l.Width).Sum();

            double cellTemp = (maxTemp - minTemp) / totalLength; // (t0+tn)/δ = q/λ

            double x = 0;
            foreach (Layer layer in layers)
            {
                x += layer.Width;
                layer.Temp = maxTemp - cellTemp * x;
            }

            double heatResist = 0;
            foreach (Layer layer in layers)
            {
                layer.Lambda = layer.ParamA + layer.ParamB * Math.Pow(10, -3) * layer.Temp + layer.ParamC * Math.Pow(10, -6) * Math.Pow(layer.Temp, 2); //L=A+B*10e-3*t+C*10e-6*t^2
                heatResist += layer.Width / layer.Lambda; // δ/λ
            }

            double heatFlow = 0;
            heatFlow = (maxTemp - minTemp) / heatResist;

            const double secondsPerYear = 31536000;
            double height = Convert.ToDouble(ovenHeight.Text);
            double radius = Convert.ToDouble(ovenDiametr.Text) / 2;
            double heat = heatFlow * (2 * Math.PI * radius * (radius + height)) * secondsPerYear;
            double price = Convert.ToDouble(gasPrice.Text);
            double loss = (heat * price * 100) / (35000000 * 1e6);
            financeLoss.Text = "Финансовые потери за год: \n" + loss.ToString("#.##") + " млн. рублей";
        }
    }
}
