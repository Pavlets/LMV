using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Maket_PZ
{
    public partial class MenuMed : Form
    {
        bool chart_start = false;
        FactorsMed g = new FactorsMed();
        bool factors_menu = false;
        public MenuMed()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(CitySize, "Чисельність населення на даний момент");
            //t.SetToolTip(dateTimePicker, "Дата кінця побудови графіка");
            CitySize.ForeColor = Color.Gray;
            CitySize.Font = new Font("Constantia", 10, FontStyle.Italic);
            //dateTimePicker.CustomFormat = "M.yyyy";
            //dateTimePicker.MinDate = DateTime.Today;
            //dateTimePicker.Value = DateTime.Today;

            diagram.ChartAreas[0].CursorX.IsUserEnabled = true;
            diagram.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            diagram.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            diagram.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Data.close_menu_med = true;
            g.Close();
            EnterMenu f = new EnterMenu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (factors_menu)
                g.WindowState = FormWindowState.Normal;
            else
            {
                g.Show();
                factors_menu = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Diagram_radio.Checked)
            {
                int[] yValues = new int[Data.med_factor_count];
                string[] xValues = new string[Data.med_factor_count];
                for (int i = 0; i < Data.med_factor_count; i++)
                {
                    yValues[i] = Data.Factor_med[i].sick;
                    xValues[i] = Data.Factor_med[i].name;
                    MessageBox.Show(xValues[i]);
                }
                diagram.Series[0].Points.DataBindXY(xValues, yValues);
            }
            else
            {

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (CitySize.ForeColor == Color.Gray)
            {
                CitySize.Text = "";
                CitySize.Font = new Font("Franklin Gothic", 10, FontStyle.Regular);
                CitySize.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (CitySize.Text == "")
            {
                CitySize.ForeColor = Color.Gray;
                CitySize.Font = new Font("Constantia", 10, FontStyle.Italic);
                CitySize.Text = "чис. населення";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            diagram.Series[0].Color = colorDialog.Color;
        }

        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            if (chart_start)
                ChartStart.PerformClick();
        }

        private void CitySize_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = !(e.KeyCode == Keys.D0 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right);
        }

        private void Diagram_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Diagram_radio.Checked)
            {
                ChartStart.Text = "Побудувати діаграму";
                label2.Text = "Колір діаграми";
            }
            else
            {
                ChartStart.Text = "Побудувати графiк";
                label2.Text = "Колір графіка";
            }
        }
    }
}
