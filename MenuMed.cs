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
            t.SetToolTip(Days_future, "Кількість прогнозованих днів");
            Days_future.ForeColor = Color.Gray;
            Days_future.Font = new Font("Constantia", 10, FontStyle.Italic);
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
                }
                diagram.Series[0].Points.DataBindXY(xValues, yValues);
            }
            else
            {

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Days_future.ForeColor == Color.Gray)
            {
                Days_future.Text = "";
                Days_future.Font = new Font("Franklin Gothic", 10, FontStyle.Regular);
                Days_future.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Days_future.Text == "")
            {
                Days_future.ForeColor = Color.Gray;
                Days_future.Font = new Font("Constantia", 10, FontStyle.Italic);
                Days_future.Text = "кількість днів";
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
                comboBox.Enabled = true;
                comboBox.Visible = true;
                Days_future.Enabled = false;
                Days_future.Visible = false;
            }
            else
            {
                ChartStart.Text = "Побудувати графiк";
                comboBox.Enabled = false;
                comboBox.Visible = false;
                Days_future.Enabled = true;
                Days_future.Visible = true;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
                diagram.Palette = ChartColorPalette.BrightPastel;
            else if (comboBox.SelectedIndex == 1)
                diagram.Palette = ChartColorPalette.Bright;
            else if (comboBox.SelectedIndex == 2)
                diagram.Palette = ChartColorPalette.Grayscale;
            else if (comboBox.SelectedIndex == 3)
                diagram.Palette = ChartColorPalette.Excel;
            else if (comboBox.SelectedIndex == 4)
                diagram.Palette = ChartColorPalette.Light;
            else if (comboBox.SelectedIndex == 5)
                diagram.Palette = ChartColorPalette.Pastel;
            else if (comboBox.SelectedIndex == 6)
                diagram.Palette = ChartColorPalette.EarthTones;
            else if (comboBox.SelectedIndex == 7)
                diagram.Palette = ChartColorPalette.SemiTransparent;
            else if (comboBox.SelectedIndex == 8)
                diagram.Palette = ChartColorPalette.Berry;
            else if (comboBox.SelectedIndex == 9)
                diagram.Palette = ChartColorPalette.Chocolate;
            else if (comboBox.SelectedIndex == 10)
                diagram.Palette = ChartColorPalette.Fire;
            else
                diagram.Palette = ChartColorPalette.SeaGreen;
        }
    }
}
